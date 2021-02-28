using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class DamageTypeParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedDamageType Value;

        public override object value { get => Value; set => Value = (SharedDamageType) value; }

        public override Type GetValueType() => typeof(SharedDamageType);
    }
}