using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Graph.Drawers
{
    [FieldDrawer(typeof(SharedVector3))]
    public class Vector3Drawer : VisualElement, INotifyValueChanged<SharedVector3>
    {
        private readonly Vector3Field _inputField;
        private SharedVector3 _value;

        public Vector3Drawer(string label)
        {
            _inputField = new Vector3Field(label);
            _inputField.RegisterValueChangedCallback(e =>
            {
                value = e.newValue;
            });
            
            Add(_inputField);
            _value = new SharedVector3();
        }

        public void SetValueWithoutNotify(SharedVector3 newValue)
        {
            _value = newValue;
            _inputField.SetValueWithoutNotify(newValue.Value);
        }

        public SharedVector3 value
        {
            get => _value;
            set
            {
                if (EqualityComparer<Vector3>.Default.Equals(_value.Value, value.Value))
                    return;
                if (panel != null)
                {
                    using (var pooled = ChangeEvent<SharedVector3>.GetPooled(_value, value))
                    {
                        pooled.target = this;
                        SetValueWithoutNotify(value);
                        SendEvent(pooled);
                    }
                }
                else
                    SetValueWithoutNotify(value);
            }
        }
    }
}