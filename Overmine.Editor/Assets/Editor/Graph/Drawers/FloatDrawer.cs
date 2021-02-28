using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Drawers
{
    [FieldDrawer(typeof(SharedFloat))]
    public class FloatDrawer : VisualElement, INotifyValueChanged<SharedFloat>
    {
        private readonly FloatField _inputField;
        private SharedFloat _value;

        public FloatDrawer(string label)
        {
            _inputField = new FloatField(label);
            _inputField.RegisterValueChangedCallback(e =>
            {
                value = e.newValue;
            });
            
            Add(_inputField);
            _value = new SharedFloat();
        }

        public void SetValueWithoutNotify(SharedFloat newValue)
        {
            _value = newValue;
            _inputField.SetValueWithoutNotify(newValue.Value);
        }

        public SharedFloat value
        {
            get => _value;
            set
            {
                if (EqualityComparer<float>.Default.Equals(_value.Value, value.Value))
                    return;
                if (panel != null)
                {
                    using (var pooled = ChangeEvent<SharedFloat>.GetPooled(_value, value))
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