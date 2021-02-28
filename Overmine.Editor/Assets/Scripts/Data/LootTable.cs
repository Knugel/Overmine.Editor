using System;
using System.Collections.Generic;
using Thor;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Loot Table", menuName = "Data/Loot Table")]
    public class LootTable : ScriptableObject, ISerializationCallbackReceiver
    {
        public string Guid;
        
        public string Name;

        [Header("Rerolling")]
        public Rand.StateType RandStateType;

        public ItemData.ItemHint RerollHint;

        [Header("Fallbacks")]
        public LootTable FallbackTable;

        public Item DefaultLoot;
        
        [Header("Loot")]
        public List<Loot> Entries;
        
        [Serializable]
        public struct Loot
        {
            public int Weight;

            public ItemData Item;
        }
        
        public void OnBeforeSerialize()
        {
            if (string.IsNullOrEmpty(Guid))
                Guid = GUID.get();
        }

        public void OnAfterDeserialize() { }
    }
}