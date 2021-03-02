using System;
using System.Collections.Generic;
using Thor;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "LocDB", menuName = "Data/LocDB")]
    public class LocDB : ScriptableObject
    {
        public Localizer.LanguageType Language;

        public List<Entry> Entries;
        
        [Serializable]
        public struct Entry
        {
            public string Key;

            public string Text;
        }
    }
}