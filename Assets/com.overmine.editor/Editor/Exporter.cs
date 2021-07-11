using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Editor
{
    public static class Exporter
    {
        public const string ExportPath = "Output";
        public const string AssemblyFolder = "Library/ScriptAssemblies";
        
        [MenuItem("Overmine/Build")]
        public static void BuildMod()
        {
            var info = FindAssetsByType<ModInfo>().FirstOrDefault();
            if (info == null)
            {
                Debug.LogError("Couldn't find a mod asset in this project!");
                return;
            }
            
            BuildBundle(info.Bundle);
            BuildAssembly(info.Assembly);
            BuildInfo(info);

            Debug.Log($"Finished building mod '{info.ID}'.");
            
            if(info.CopyToGameDirectory)
                CopyMod(info);
        }

        private static void BuildBundle(string name)
        {
            AssetDatabase.StartAssetEditing();
            var guids = AssetDatabase.FindAssets("", new [] { "Assets/Resources" });
            foreach (var guid in guids)
            {
                var asset = AssetDatabase.GUIDToAssetPath(guid);
                var imported = AssetImporter.GetAtPath(asset);
                imported.SetAssetBundleNameAndVariant(name, null);
            }
            AssetDatabase.StopAssetEditing();
            
            if (Directory.Exists(ExportPath))
            {
                Directory.Delete(ExportPath, true);
            }
            Directory.CreateDirectory(ExportPath);
            
            BuildPipeline.BuildAssetBundles(ExportPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        }

        private static void BuildAssembly(TextAsset definition)
        {
            var source = Path.Combine(AssemblyFolder, definition.name + ".dll");
            var target = Path.Combine(ExportPath, definition.name + ".dll");
            
            File.Copy(source, target);
        }

        private static void BuildInfo(ModInfo asset)
        {
            var info = new Overmine.API.ModInfo
            {
                Id = asset.ID,
                Name = asset.Name,
                Version = asset.Version,
                Description = asset.Description,
                EntryDLL = asset.Assembly.name + ".dll",
                Bundles = new[] {asset.Bundle}
            };
            File.WriteAllText(Path.Combine(ExportPath, "mod.json"), JsonConvert.SerializeObject(info, Formatting.Indented));
        }

        private static void CopyMod(ModInfo info)
        {
            var directory = GetGameDirectory();
            if (directory == null)
                return;

            directory = Path.Combine(directory, "Mods", info.ID);

            if(Directory.Exists(directory))
                Directory.Delete(directory, true);
            Directory.CreateDirectory(directory);

            foreach (var file in Directory.EnumerateFiles(ExportPath))
            {
                File.Copy(file, Path.Combine(directory, Path.GetFileName(file)));
            }
            
            Debug.Log($"Copied mod files to '{directory}'.");
        }
        
        private static List<T> FindAssetsByType<T>() where T : Object
        {
            var assets = new List<T>();
            var guids = AssetDatabase.FindAssets($"t:{typeof(T)}");
            foreach(var guid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath( guid );
                var asset = AssetDatabase.LoadAssetAtPath<T>( assetPath );
                if(asset != null)
                {
                    assets.Add(asset);
                }
            }
            return assets;
        }
        
        private static string GetGameDirectory()
        {
            try
            {
                using (var key =
                    Registry.LocalMachine.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 656350"))
                {
                    return key?.GetValue("InstallLocation")?.ToString();
                }
            }
            catch (Exception)
            {
                Debug.LogWarning("Error while trying to read registry key for UnderMine!");
                Debug.LogWarning($"Can't copy mod to game directoy!");
                return null;
            }
        }
    }
}