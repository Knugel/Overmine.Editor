using System.IO;
using Data;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class ResourceDataExporter : AssetExporter<Resource, ResourceData>
    {
        protected override Object PrepareExport(string path, Resource source, Exporter exporter)
        {
            var resourceData = ScriptableObject.CreateInstance<ResourceData>();
            AssetDatabase.CreateAsset(resourceData, Path.Combine(path, $"{source.name}.asset"));
            return resourceData;
        }
        
        protected override Object OnExport(string path, Resource source, ResourceData result, Exporter exporter)
        {
            result.SetField("m_guid", source.guid);
            result.SetField("m_name", source.Name);
            result.SetField("m_type", source.Type);
            return null;
        }
    }
}