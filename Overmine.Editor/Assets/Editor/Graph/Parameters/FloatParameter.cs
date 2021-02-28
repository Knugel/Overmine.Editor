using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class FloatParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedFloat Value;

        public override object value { get => Value; set => Value = (SharedFloat) value; }

        public override Type GetValueType() => typeof(SharedFloat);
    }
}