using System;
using GraphProcessor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class ObjectParameter : ExposedParameter
    {
        [SerializeField] 
        private object Value;

        public override object value { get => Value; set => Value = value; }

        public override Type GetValueType() => typeof(object);
    }
}