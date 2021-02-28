using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Editor.Export
{
    public static class ExportHelper
    {
        public static void SetField<T>(this T obj, string name, object value)
        {
            var info = typeof(T).GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (info == null)
            {
                if (typeof(T) == typeof(MemberInfo))
                    throw new ArgumentException($"Field {name} not found on Type {typeof(T)}");
                
                SetField(typeof(T).BaseType, name, obj, value);
                return;
            }
            info.SetValue(obj, value);
        }

        private static void SetField(Type type, string name, object obj, object value)
        {
            var info = type.GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (info == null)
            {
                if (type == typeof(object))
                    throw new ArgumentException($"Field {name} not found on Type {type}");
                
                SetField(type.BaseType, name, obj, value);
                return;
            }
            info.SetValue(obj, value);
        }

        public static List<AssetPath> FindAssetsByType<T>() where T : UnityEngine.Object
        {
            var assets = new List<AssetPath>();
            var guids = AssetDatabase.FindAssets($"t:{typeof(T)}");
            foreach (var guid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var asset = AssetDatabase.LoadAssetAtPath<T>(assetPath);
                if(asset != null)
                {
                    assets.Add(new AssetPath(assetPath, asset));
                }
            }
            return assets;
        }
        
        public static List<AssetPath> FindPrefabsOfType<T>() where T : UnityEngine.Object
        {
            var assets = new List<AssetPath>();
            var guids = AssetDatabase.FindAssets("t:GameObject");
            foreach (var guid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var asset = AssetDatabase.LoadAssetAtPath<T>(assetPath);
                if(asset != null)
                {
                    var go = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
                    if (go.GetComponentsInChildren<T>().Any())
                        assets.Add(new AssetPath(assetPath, go));
                }
            }
            return assets;
        }
    }
}