using System.IO;
using Components;
using UnityEditor;
using UnityEngine;

namespace Editor.Data
{
    public static class DataCallback
    {
        [MenuItem("Assets/Create/Prefab/Status Effect")]
        public static void CreateStatusEffect()
        {
            var statusEffect = new GameObject();
            statusEffect.AddComponent<Entity>();
            statusEffect.AddComponent<StatusEffect>();
            PrefabUtility.SaveAsPrefabAsset(statusEffect, Path.Combine(GetSelectedPath(), "StatusEffect.prefab"));
        }
        
        private static string GetSelectedPath()
        {
            var path = "Assets";
  
            foreach (var obj in Selection.GetFiltered(typeof(Object), SelectionMode.Assets))
            {
                path = AssetDatabase.GetAssetPath(obj);
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    path = Path.GetDirectoryName(path);
                    break;
                }
            }
            return path;
        }
    }
}