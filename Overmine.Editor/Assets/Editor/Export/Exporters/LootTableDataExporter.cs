using System.IO;
using System.Linq;
using Data;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class LootTableDataExporter : AssetExporter<LootTable, LootTableData>
    {
        protected override Object PrepareExport(string path, LootTable source, Exporter exporter)
        {
            var lootTable = ScriptableObject.CreateInstance<LootTableData>();
            AssetDatabase.CreateAsset(lootTable, Path.Combine(path, $"{source.name}.asset"));
            return lootTable;
        }

        protected override Object OnExport(string path, LootTable source, LootTableData result, Exporter exporter)
        {
            result.SetField("m_guid", source.guid);
            result.SetField("m_name", source.Name);
            result.SetField("m_randStateType", source.RandStateType);
            result.SetField("m_rerollHint", source.RerollHint);
            result.SetField("m_fallbackTable", exporter.Export(source.FallbackTable));
            result.SetField("m_defaultLoot", exporter.Export(source.DefaultLoot));

            var entries = source.Entries.Select(x => new LootTableData.LootData
            {
                weight = x.Weight,
                item = exporter.Export(x.Item) as ItemData
            }).ToList();
            result.SetField("m_loot", entries);
            return null;
        }
    }
}