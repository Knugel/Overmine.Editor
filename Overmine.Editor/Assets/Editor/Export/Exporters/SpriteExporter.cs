using System.IO;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class SpriteExporter : AssetExporter<Sprite, Sprite>
    {
        protected override Object OnExport(string path, Sprite source, Sprite result, Exporter exporter)
        {
            var sourcePath = AssetDatabase.GetAssetPath(source);
            var destPath = Path.Combine(path, $"{source.name}.png");
            
            AssetDatabase.CopyAsset(sourcePath, destPath);
            return AssetDatabase.LoadAssetAtPath(destPath, typeof (Sprite));
        }
    }
}