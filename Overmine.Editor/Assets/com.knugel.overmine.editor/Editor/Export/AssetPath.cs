namespace Editor.Export
{
    public class AssetPath
    {
        public readonly string Path;

        public readonly UnityEngine.Object Asset;

        public AssetPath(string path, UnityEngine.Object asset)
        {
            Path = path;
            Asset = asset;
        }
    }
}