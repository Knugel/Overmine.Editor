using System.Collections.Generic;
using Data;
using Thor;
using UnityEngine;

namespace Components
{
    public class Entity : MonoBehaviour, ISerializationCallbackReceiver
    {
        public EntityInfo Data;

        public string Guid;

        [Tooltip("Should this entity be constrained to playable bounds?")]
        public bool Constrain;

        [Tooltip("Should this Entity be put on the global 'Entities' list so that you can find with with a 'Filter' action?")]
        public bool Filterable;

        [Tooltip("Does this Entity stick around when you change rooms?")]
        public bool Persistent = true;

        [Tooltip("Does this Entity inherit the team of its Root?")]
        public bool InheritTeam = true;

        public List<string> InitialTags;

        public AllianceManager.Team Team;

        public int AgentTypeID;

        public Thor.Entity.InitPhaseType InitPhase;

        public Thor.Entity.SortType SortingType;

        public bool DoorBlocker;

        public int UserData;

        public string UserString;

        public List<Popup.PopupOffset> PopupOffsets;
        
        public void OnBeforeSerialize()
        {
            if (string.IsNullOrEmpty(Guid))
                Guid = GUID.get();
        }

        public void OnAfterDeserialize() { }
    }
}