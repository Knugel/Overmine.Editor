using Thor;
using UnityEngine;

namespace Data
{
    public class EntityInfo : Identifiable
    {
        public Sprite Icon;
        
        public Sprite Portrait;
        
        public string DisplayName;
        
        public string Description;
        
        public string Flavor;
        
        public EntityData.RarityType Rarity;
        
        public bool ShowInJournal = true;
        
        public bool IsDeprecated;
    }
}