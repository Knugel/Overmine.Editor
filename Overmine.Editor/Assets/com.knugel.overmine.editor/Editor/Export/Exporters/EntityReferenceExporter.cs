using System.IO;
using Data;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class EntityReferenceExporter : AssetExporter<EntityReference, Entity>
    {
        protected override Object OnExport(string path, EntityReference source, Entity result, Exporter exporter)
        {
            var root = new GameObject();
            var entity = root.AddComponent<Entity>();
            entity.SetField("m_guid", source.guid);
            
            var prefab = PrefabUtility.SaveAsPrefabAsset(root, Path.Combine(path, $"{source.name}.prefab"));
            return prefab.GetComponent<Entity>();
        }
    }
}