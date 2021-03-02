using UnityEngine;
using Object = System.Object;

namespace Editor.Export.Exporters
{
    public abstract class ComponentExporter
    {
        public abstract void OnExport(GameObject root, Object source, Exporter exporter);
    }

    public abstract class ComponentExporter<T> : ComponentExporter where T : MonoBehaviour
    {
        public abstract void OnExport(GameObject root, T source, Exporter exporter);

        public override void OnExport(GameObject root, object source, Exporter exporter)
        {
            OnExport(root, source as T, exporter);
        }
    }
}