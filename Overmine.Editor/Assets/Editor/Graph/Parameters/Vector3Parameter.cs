using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class Vector3Parameter : ExposedParameter
    {
        [SerializeField] 
        private SharedVector3 Value;

        public override object value { get => Value; set => Value = (SharedVector3) value; }

        public override Type GetValueType() => typeof(SharedVector3);
    }
}