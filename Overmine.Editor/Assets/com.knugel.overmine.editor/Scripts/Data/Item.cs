using System.Collections.Generic;
using Thor;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Item", menuName = "Data/Item")]
    public class Item : EntityInfo
    {
        public ItemData.ItemHint Hint;

        public string Slot;

        public string Audio;

        public List<string> Tags;

        public List<ItemData.CostGroup> CostGroups;

        public int MaxDropCount = 1;

        public bool IsDefault;

        public bool IsDefaultDiscovered;

        [Tooltip("Does this Item automatically unlock when it's discovered?")]
        public bool AutoUnlock;

        public bool Rerollable = true;

        public bool AllowOnAltar = true;

        [Header("Primary")]
        public BehaviourGraph PickedUpBehaviour;

        [Header("Secondary")]
        public BehaviourGraph SecondaryPickedUpBehaviour;

        public bool IsSpecialDrop;

        public bool IsSpecialDiscovery;

        [Header("Combo")]
        public Item ComboPiece;

        public Item ComboResult;

        [Header("Misc")]
        public int UserData;

        public List<Requirement> DropRequirements;

        public List<Requirement> DiscoverRequirements;
    }
}