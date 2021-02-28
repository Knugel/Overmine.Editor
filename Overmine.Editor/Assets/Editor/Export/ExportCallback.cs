using System.Collections.Generic;
using System.IO;
using System.Linq;
using Components;
using Data;
using UnityEditor;

namespace Editor.Export
{
    public static class ExportCallback
    {
        public const string Path = "Assets/Build";
        
        [MenuItem("Overmine/Build")]
        public static void BuildAssetBundle()
        {
            if (Directory.Exists(Path))
            {
                Directory.Delete(Path, true);
                Directory.CreateDirectory(Path);
            }

            var assetsPaths = GatherAssets();
            var exporter = new Exporter(Path);

            foreach (var path in assetsPaths)
                exporter.Export(path.Asset);
            
            foreach (var result in exporter.Results)
            {
                var path = AssetDatabase.GetAssetPath(result.Result);
                AssetImporter.GetAtPath(path).SetAssetBundleNameAndVariant("Overmine", "");
            }
        }

        [MenuItem("Overmine/Bundle")]
        public static void BundleAssetBundle()
        {
            BuildAssetBundle();
            
            BuildPipeline.BuildAssetBundles("Output", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
            
            // Delete unnecessary bundles
            File.Delete("Output/Output");
            File.Delete("Output/Output.manifest");
        }

        private static IEnumerable<AssetPath> GatherAssets()
        {
            var items = ExportHelper.FindAssetsByType<Item>();
            var statusEffects = ExportHelper.FindPrefabsOfType<StatusEffect>();
            return items.Concat(statusEffects);
        }
    }
}