using System.IO;
using System.Text;
using Data;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class LocDBExporter : AssetExporter<LocDB, TextAsset>
    {
        protected override Object OnExport(string path, LocDB source, TextAsset result, Exporter exporter)
        {
            var sb = new StringBuilder();
            foreach (var entry in source.Entries)
                sb.AppendLine($"{entry.Key};{entry.Text}");

            var textAsset = new TextAsset(sb.ToString());
            AssetDatabase.CreateAsset(textAsset, Path.Combine(path, $"{source.Language}.asset"));
            return textAsset;
        }
    }
}