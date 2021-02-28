using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Data;
using Editor.Export.Exporters;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export
{
    public class Exporter
    {
        private static readonly Dictionary<Type, AssetExporter> Exporters = new Dictionary<Type, AssetExporter>
        {
            { typeof(Item), new ItemExporter() },
            { typeof(BehaviourGraph), new BehaviourGraphExporter() },
            { typeof(EntityData), new EntityDataExporter() },
            { typeof(GameObject), new GameObjectExporter() },
            { typeof(Sprite), new SpriteExporter() }
        };
        
        private readonly List<ExportResult> _assets;
        private readonly string _path;

        public List<ExportResult> Results => _assets;
        
        public Exporter(string path)
        {
            _assets = new List<ExportResult>();
            _path = path;
        }

        public UnityEngine.Object Export(UnityEngine.Object source)
        {
            if (source == null)
                return null;
            
            var path = AssetDatabase.GetAssetPath(source);
            path = Path.GetDirectoryName(path);
            path = Path.Combine(_path, GetPath(path));

            var existing = _assets.FirstOrDefault(x => x.Source == source);
            if (existing != null)
                return existing.Result;

            var exporter = Exporters[source.GetType()];

            var prepared = exporter.PrepareExport(path, source, this);
            if (prepared != null)
            {
                _assets.Add(new ExportResult(source, prepared));
                exporter.OnExport(path, source, prepared, this);
                return prepared;
            }
            else
            {
                var result = exporter.OnExport(path, source, null, this);
                _assets.Add(new ExportResult(source, result));
                return result;
            }
        }

        private string GetPath(string path)
        {
            var idx = path.IndexOf(Path.DirectorySeparatorChar);
            if (idx == -1)
                return path.Replace("Assets", "");
            return path.Substring(idx + 1);
        }
    }
}