using System;
using GraphProcessor;
using Thor;
using UnityEngine;

namespace Editor.Graph.Parameters
{
    [Serializable]
    public class DataObjectParameter : ExposedParameter
    {
        [SerializeField] 
        private SharedDataObject Value;

        public override object value { get => Value; set => Value = (SharedDataObject) value; }

        public override Type GetValueType() => typeof(SharedDataObject);
    }
}