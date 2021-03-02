using System;
using GraphProcessor;
using Thor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class EntityListParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedEntityList Value;

        public override object value { get => Value; set => Value = (SharedEntityList) value; }

        public override Type GetValueType() => typeof(SharedEntityList);
    }
}