using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class Vector2Parameter : ExposedParameter
    {
        [SerializeField] 
        private SharedVector2 Value;

        public override object value { get => Value; set => Value = (SharedVector2) value; }

        public override Type GetValueType() => typeof(SharedVector2);
    }
}