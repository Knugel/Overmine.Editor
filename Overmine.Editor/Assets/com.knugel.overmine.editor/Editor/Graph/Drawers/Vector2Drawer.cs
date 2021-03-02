using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Graph.Drawers
{
    [FieldDrawer(typeof(SharedVector2))]
    public class Vector2Drawer : VisualElement, INotifyValueChanged<SharedVector2>
    {
        private readonly Vector2Field _inputField;
        private SharedVector2 _value;

        public Vector2Drawer(string label)
        {
            _inputField = new Vector2Field(label);
            _inputField.RegisterValueChangedCallback(e =>
            {
                value = e.newValue;
            });
            
            Add(_inputField);
            _value = new SharedVector2();
        }

        public void SetValueWithoutNotify(SharedVector2 newValue)
        {
            _value = newValue;
            _inputField.SetValueWithoutNotify(newValue.Value);
        }

        public SharedVector2 value
        {
            get => _value;
            set
            {
                if (EqualityComparer<Vector2>.Default.Equals(_value.Value, value.Value))
                    return;
                if (panel != null)
                {
                    using (var pooled = ChangeEvent<SharedVector2>.GetPooled(_value, value))
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