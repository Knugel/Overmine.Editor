using System.IO;
using Data;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class EntityDataExporter : AssetExporter<EntityInfo, EntityData>
    {
        protected override Object PrepareExport(string path, EntityInfo source, Exporter exporter)
        {
            var entityData = ScriptableObject.CreateInstance<EntityData>();
            AssetDatabase.CreateAsset(entityData, Path.Combine(path, $"{source.name}.asset"));
            return entityData;
        }

        protected override Object OnExport(string path, EntityInfo source, EntityData result, Exporter exporter)
        {
            result.SetField("m_guid", source.guid);
            result.SetField("m_icon", exporter.Export(source.Icon));
            result.SetField("m_portrait", exporter.Export(source.Portrait));
            result.SetField("m_displayName", new LocID { Text = source.DisplayName } );
            result.SetField("m_description", new LocID { Text = source.Description });
            result.SetField("m_flavor", new LocID { Text = source.Flavor });
            result.SetField("m_rarity", source.Rarity);
            result.SetField("m_showInJournal", source.ShowInJournal);
            result.SetField("m_isDeprecated", source.IsDeprecated);
            return null;
        }
    }
}