using System;
using System.Collections.Generic;
using System.IO;
using Components;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Editor.Export.Exporters
{
    public class GameObjectExporter : AssetExporter<GameObject, GameObject>
    {
        private static readonly Dictionary<Type, ComponentExporter> Exporters = new Dictionary<Type, ComponentExporter>
        {
            { typeof(Entity), new EntityExporter() },
            { typeof(StatusEffect), new StatusEffectExporter() },
        };

        protected override Object PrepareExport(string path, GameObject source, Exporter exporter)
        {
            var root = new GameObject();
            return PrefabUtility.SaveAsPrefabAsset(root, Path.Combine(path, $"{source.name}.prefab"));
        }

        protected override Object OnExport(string path, GameObject source, GameObject result, Exporter exporter)
        {
            foreach(var component in source.GetComponents<Component>())
            {
                if (Exporters.TryGetValue(component.GetType(), out var export))
                {
                    export.OnExport(result, component, exporter);
                }
            }
            PrefabUtility.SavePrefabAsset(result);
            return null;
        }
    }
}