using System;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using UnityEditor;
using UnityEngine;

namespace Editor.Locator
{
    [InitializeOnLoad]
    public static class Locator
    {
        private static readonly string[] Required =
        {
            "BehaviorDesigner.dll", "BehaviorDesigner.Runtime.dll", "BugSplat.Unity.dll", "Cocuy.Unity.dll",
            "Colorful.Unity.dll", "DemiLib.dll", "Discord.Unity.dll", "DOTween.dll", "DOTween43.dll", "DOTween46.dll",
            "DOTween50.dll", "DOTweenPro.dll", "FMOD.Unity.dll", "NavMesh.Unity.dll", "Newtonsoft.Json.dll",
            "Overmine.API.dll", "ProceduralLightning.Unity.dll", "Rewired.Unity.dll", "Rewired_Core.dll",
            "Rewired_Windows.dll", "Steamworks.NET.dll", "SuperSplinesPro.Unity.dll", "UnderMine.dll",
            "Unity.TextMeshPro.dll"
        };

        private static readonly string LibraryFolder = GetLibraryFolder();
        
        static Locator()
        {
            var existing = Directory.GetFiles(LibraryFolder)
                .Select(Path.GetFileName)
                .ToList();
            var missing = Required
                .Except(existing)
                .ToList();
            
            if (missing.Any())
            {
                var game = GetGameDirectory();
                if (game == null)
                {
                    Debug.LogWarning($"Missing {string.Join(", ", missing)}");
                    return;
                }

                var managed = Path.Combine(game, "Undermine_Data", "Managed");
                foreach (var file in missing)
                {
                    var path = Path.Combine(managed, file);
                    if (File.Exists(path))
                    {
                        File.Copy(path, Path.Combine(LibraryFolder, file));
                    }
                    else
                    {
                        Debug.LogWarning($"Couldn't find required library '{file}' in the UnderMine directory");
                    }
                }
            }
        }

        private static string GetLibraryFolder()
        {
            var path = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(ScriptableObject.CreateInstance<Dummy>()));
            return Path.Combine(Path.GetDirectoryName(path), "..", "..", "Libraries");
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
                Debug.LogWarning($"Please copy all missing .dlls file into {LibraryFolder} manually.");
                return null;
            }
        }
    }   
}
