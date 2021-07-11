using UnityEngine;

namespace Editor
{
    [CreateAssetMenu(fileName = "Mod Info", menuName = "Data/Mod Info")]
    public class ModInfo : ScriptableObject
    {
        [Header("Info")]
        public string ID;
        
        public string Name;

        [Multiline]
        public string Description;

        public string Version;
        
        [Header("Bundle Name")]
        public string Bundle;

        [Header("Assembly Definition")]
        public TextAsset Assembly;

        [Header("Build Settings")] 
        public bool CopyToGameDirectory;
    }
}