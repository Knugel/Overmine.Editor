using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Drawers
{
    [FieldDrawer(typeof(SharedDamageType))]
    public class DamageTypeDrawer : VisualElement, INotifyValueChanged<SharedDamageType>
    {
        private readonly EnumField _inputField;
        private SharedDamageType _value;

        public DamageTypeDrawer(string label)
        {
            _inputField = new EnumField(label, HealthExt.DamageType.Physical);
            _inputField.RegisterValueChangedCallback(e =>
            {
                value = (HealthExt.DamageType) e.newValue;
            });
            
            Add(_inputField);
            _value = new SharedDamageType();
        }

        public void SetValueWithoutNotify(SharedDamageType newValue)
        {
            _value = newValue;
            _inputField.SetValueWithoutNotify(newValue.Value);
        }

        public SharedDamageType value
        {
            get => _value;
            set
            {
                if (EqualityComparer<HealthExt.DamageType>.Default.Equals(_value.Value, value.Value))
                    return;
                if (panel != null)
                {
                    using (var pooled = ChangeEvent<SharedDamageType>.GetPooled(_value, value))
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