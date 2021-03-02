using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class StringParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedString Value;

        public override object value { get => Value; set => Value = (SharedString) value; }

        public override Type GetValueType() => typeof(SharedString);
    }
}