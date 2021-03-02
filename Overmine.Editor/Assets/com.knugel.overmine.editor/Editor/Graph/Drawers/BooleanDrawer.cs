using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using UnityEngine.UIElements;

namespace Editor.Graph.Drawers
{
    [FieldDrawer(typeof(SharedBool))]
    public class BooleanDrawer : VisualElement, INotifyValueChanged<SharedBool>
    {
        private readonly Toggle _inputField;
        private SharedBool _value;

        public BooleanDrawer(string label)
        {
            _inputField = new Toggle(label);
            _inputField.RegisterValueChangedCallback(e =>
            {
                value = e.newValue;
            });
            
            Add(_inputField);
            _value = new SharedBool();
        }

        public void SetValueWithoutNotify(SharedBool newValue)
        {
            _value = newValue;
            _inputField.SetValueWithoutNotify(newValue.Value);
        }

        public SharedBool value
        {
            get => _value;
            set
            {
                if (EqualityComparer<bool>.Default.Equals(_value.Value, value.Value))
                    return;
                if (panel != null)
                {
                    using (var pooled = ChangeEvent<SharedBool>.GetPooled(_value, value))
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