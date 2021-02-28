using System;
using System.IO;
using Object = UnityEngine.Object;

namespace Editor.Export.Exporters
{
    public abstract class AssetExporter
    {
        public abstract Object OnExport(string path, Object source, Object result, Exporter exporter);

        public abstract Object PrepareExport(string path, Object source, Exporter exporter);
    }
    
    public abstract class AssetExporter<T, U> : AssetExporter where T : Object where U : Object
    {
        protected abstract Object OnExport(string path, T source, U result, Exporter exporter);

        protected virtual Object PrepareExport(string path, T source, Exporter exporter)
        {
            return null;
        }

        public override Object OnExport(string path, Object source, Object result, Exporter exporter)
        {
            path = GetDirectory(path);
            return OnExport(path, source as T, result as U, exporter);
        }

        public override Object PrepareExport(string path, Object source, Exporter exporter)
        {
            path = GetDirectory(path);
            return PrepareExport(path, source as T, exporter);
        }

        private string GetDirectory(string path)
        {
            var directory = path;
            if (Path.HasExtension(path))
                directory = Path.GetDirectoryName(path) ??
                            throw new InvalidOperationException($"Can't create directory for {path}");

            Directory.CreateDirectory(directory);
            return directory;
        }
    }
}