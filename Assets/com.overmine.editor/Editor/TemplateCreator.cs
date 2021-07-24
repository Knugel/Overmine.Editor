using System.IO;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public static class TemplateCreator
    {
        [MenuItem("Assets/Create/Templates/Relic", false, 0)]
        public static void CreateRelicTemplate()
        {
            Copy<ItemData>("Resources/Templates/Relic.asset", "Relic.asset");
        }
        
        [MenuItem("Assets/Create/Templates/Blessing", false, 0)]
        public static void CreateBlessingTemplate()
        {
            Copy<ItemData>("Resources/Templates/Blessing.asset", "Blessing.asset");
        }
        
        [MenuItem("Assets/Create/Templates/Hex", false, 0)]
        public static void CreateHexTemplate()
        {
            Copy<ItemData>("Resources/Templates/Hex.asset", "Hex.asset");
        }

        [MenuItem("Assets/Create/Templates/Minor Curse", false, 0)]
        public static void CreateMinorCurseTemplate()
        {
            Copy<ItemData>("Resources/Templates/Minor Curse.asset", "Minor Curse.asset");
        }
        
        [MenuItem("Assets/Create/Templates/Major Curse", false, 0)]
        public static void CreateMajorCurseTemplate()
        {
            Copy<ItemData>("Resources/Templates/Major Curse.asset", "Major Curse.asset");
        }
        
        [MenuItem("Assets/Create/Templates/Entity", false, 0)]
        public static void CreateEntityTemplate()
        {
            Copy<GameObject>("Resources/Templates/Entity.prefab", "Entity.prefab");
        }
        
        [MenuItem("Assets/Create/Templates/Status Effect", false, 0)]
        public static void CreateStatusEffectTemplate()
        {
            Copy<GameObject>("Resources/Templates/Status Effect.prefab", "Status Effect.prefab");
        }

        private static T Copy<T>(string source, string target) where T : Object
        {
            source = Path.Combine(AssetCreator.GetEditorFolder(), source);
            target = GetUniquePath(target);

            AssetDatabase.CopyAsset(source, target);
            var asset = AssetDatabase.LoadAssetAtPath<T>(target);

            switch (asset)
            {
                case ItemData item:
                    AssetCreator.GenerateGuid(item);
                    break;
                case GameObject obj:
                    AssetCreator.GenerateGuid(obj);
                    break;
            }
            
            AssetDatabase.SaveAssets();
            
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
            
            return asset;
        }

        private static string GetUniquePath(string file)
        {
            var obj = Selection.activeObject;
            var path = obj == null ? "Assets" : AssetDatabase.GetAssetPath(obj.GetInstanceID());
            path = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, file));
            return path;
        }
    }
}