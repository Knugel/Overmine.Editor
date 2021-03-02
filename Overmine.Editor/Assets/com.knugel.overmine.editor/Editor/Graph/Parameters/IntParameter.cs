using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class IntParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedInt Value;

        public override object value { get => Value; set => Value = (SharedInt) value; }

        public override Type GetValueType() => typeof(SharedInt);
    }
}