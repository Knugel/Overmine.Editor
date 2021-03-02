using System.Collections.Generic;
using Data;
using Thor;
using UnityEngine;

namespace Components
{
    public class StatusEffect : MonoBehaviour
    {
        public int LoadOrder;

        public float DefaultDuration = -1f;

        public StatusEffectExt.StackPolicyType StackPolicy;

        public StatusEffectExt.StatusEffectPosition Position = StatusEffectExt.StatusEffectPosition.Mid;

        public bool ShowInUI;

        [Header("Save/Load")] 
        public bool Save;

        public bool SaveUserData = true;

        [Header("UserData")]
        public string UserDataFormat;

        public string LevelFormat = "{0}";

        public List<BehaviourGraph> Behaviours;
    }
}