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
        public const string BuildPath = "Assets/Build";
        public const string ExportPath = "Output";
        
        [MenuItem("Overmine/Build")]
        public static void BuildAssetBundle()
        {
            if (Directory.Exists(BuildPath))
            {
                Directory.Delete(BuildPath, true);
                Directory.CreateDirectory(BuildPath);
            }

            var assetsPaths = GatherAssets();
            var exporter = new Exporter(BuildPath);

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

            if (Directory.Exists(ExportPath))
            {
                Directory.Delete(ExportPath, true);
            }
            Directory.CreateDirectory(ExportPath);

            BuildPipeline.BuildAssetBundles(ExportPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
            
            // Delete unnecessary bundles
            File.Delete(Path.Combine(ExportPath, "Output"));
            File.Delete(Path.Combine(ExportPath, "Output.manifest"));
        }

        private static IEnumerable<AssetPath> GatherAssets()
        {
            var items = ExportHelper.FindAssetsByType<Item>();
            var statusEffects = ExportHelper.FindPrefabsOfType<StatusEffect>();
            var localizations = ExportHelper.FindAssetsByType<LocDB>();
            var lootTables = ExportHelper.FindAssetsByType<LootTable>();
            
            return items
                .Concat(statusEffects)
                .Concat(localizations)
                .Concat(lootTables);
        }
    }
}