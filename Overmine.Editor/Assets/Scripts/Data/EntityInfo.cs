using Thor;
using UnityEngine;

namespace Data
{
    public class EntityInfo : DataObject
    {
        public Sprite Icon;
        
        public Sprite Portrait;
        
        public LocID DisplayName;
        
        public LocID Description;
        
        public LocID Flavor;
        
        public EntityData.RarityType Rarity;
        
        public bool ShowInJournal = true;
        
        public bool IsDeprecated;
    }
}