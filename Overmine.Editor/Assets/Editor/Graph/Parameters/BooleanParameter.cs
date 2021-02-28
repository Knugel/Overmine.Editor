using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class BooleanParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedBool Value;

        public override object value { get => Value; set => Value = (SharedBool) value; }

        public override Type GetValueType() => typeof(SharedBool);
    }
}