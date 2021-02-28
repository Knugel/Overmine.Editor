using System;
using GraphProcessor;
using Thor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class EntityParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedEntity Value;

        public override object value { get => Value; set => Value = (SharedEntity) value; }

        public override Type GetValueType() => typeof(SharedEntity);
    }
}