using System;
using System.IO;
using System.Reflection;
using BehaviorDesigner.Runtime;
using Overmine.API.Assets;
using Overmine.API.Assets.References;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public static class AssetCreator
    {
        private static readonly Variable[] GraphGlobals = 
        {
            new Variable
            {
                Name = "Entities",
                Type = typeof(SharedEntityList),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Avatars",
                Type = typeof(SharedEntityList),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Items",
                Type = typeof(SharedEntityList),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Projectiles",
                Type = typeof(SharedEntityList),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Bosses",
                Type = typeof(SharedEntityList),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Hazards",
                Type = typeof(SharedEntityList),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Player",
                Type = typeof(SharedEntity),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Zone",
                Type = typeof(SharedEntity),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Seed",
                Type = typeof(SharedInt),
                IsGlobal = true
            },
            new Variable
            {
                Name = "Self",
                Type = typeof(SharedEntity)
            },
            new Variable
            {
                Name = "Owner",
                Type = typeof(SharedEntity)
            },
            new Variable
            {
                Name = "Root",
                Type = typeof(SharedEntity)
            },
            new Variable
            {
                Name = "Link",
                Type = typeof(SharedEntity)
            }
        };
        
        [MenuItem("Assets/Create/Data/Item Data", false, 0)]
        public static void CreateItemData()
        {
            var asset = ScriptableObject.CreateInstance<ItemData>();
            GenerateGuid(asset);
            SaveAsset(asset, "Item.asset");
        }

        [MenuItem("Assets/Create/Data/Behavior Tree", false, 0)]
        public static void CreateBehaviorGraph()
        {
            var asset = ScriptableObject.CreateInstance<BehaviourGraph>();
            asset.Variables.AddRange(GraphGlobals);
            SaveAsset(asset, "Behavior Graph.asset");
        }
        
        [MenuItem("Assets/Create/Data/Grid Data", false, 0)]
        public static void CreateGridData()
        {
            var asset = ScriptableObject.CreateInstance<GridData>();
            GenerateGuid(asset);
            SaveAsset(asset, "Grid Data.asset");
        }
        
        [MenuItem("Assets/Create/References/Entity", false, 0)]
        public static void CreateEntityReference()
        {
            var asset = new GameObject();
            asset.AddComponent<EntityReference>();

            var obj = Selection.activeObject;
            var path = obj == null ? "Assets" : AssetDatabase.GetAssetPath(obj.GetInstanceID());
            
            path = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, "Entity.prefab"));
            PrefabUtility.SaveAsPrefabAsset(asset, path);

            UnityEngine.Object.DestroyImmediate(asset);
            
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        public static void SaveAsset(UnityEngine.Object asset, string file)
        {
            var obj = Selection.activeObject;
            var path = obj == null ? "Assets" : AssetDatabase.GetAssetPath(obj.GetInstanceID());
            
            path = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, file));
            AssetDatabase.CreateAsset(asset, path);
            AssetDatabase.SaveAssets();
            
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        public static void GenerateGuid(DataObject obj)
        {
            var field = typeof(DataObject).GetField("m_guid", BindingFlags.Instance | BindingFlags.NonPublic);
            field?.SetValue(obj, Guid.NewGuid().ToString());
        }
        
        public static void GenerateGuid(GameObject obj)
        {
            var entity = obj.GetComponent<Entity>();
            if (entity == null) return;
            
            var field = typeof(Entity).GetField("m_guid", BindingFlags.Instance | BindingFlags.NonPublic);
            field?.SetValue(entity, Guid.NewGuid().ToString());
        }

        public static string GetEditorFolder()
        {
            var path = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(ScriptableObject.CreateInstance<ModInfo>()));
            return Path.GetDirectoryName(path);
        }
    }
}