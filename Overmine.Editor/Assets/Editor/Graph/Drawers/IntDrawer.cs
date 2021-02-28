using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Drawers
{
    [FieldDrawer(typeof(SharedInt))]
    public class IntDrawer : VisualElement, INotifyValueChanged<SharedInt>
    {
        private readonly IntegerField _inputField;
        private SharedInt _value;

        public IntDrawer(string label)
        {
            _inputField = new IntegerField(label);
            _inputField.RegisterValueChangedCallback(e =>
            {
                value = e.newValue;
            });
            
            Add(_inputField);
            _value = new SharedInt();
        }

        public void SetValueWithoutNotify(SharedInt newValue)
        {
            _value = newValue;
            _inputField.SetValueWithoutNotify(newValue.Value);
        }

        public SharedInt value
        {
            get => _value;
            set
            {
                if (EqualityComparer<int>.Default.Equals(_value.Value, value.Value))
                    return;
                if (panel != null)
                {
                    using (var pooled = ChangeEvent<SharedInt>.GetPooled(_value, value))
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