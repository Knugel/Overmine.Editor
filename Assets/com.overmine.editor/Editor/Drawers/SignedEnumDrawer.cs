using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    public class SignedEnumDrawer<T> : PropertyDrawer where T : Enum
    {
        private readonly List<string> _values;
        private readonly int _offset;
        
        public SignedEnumDrawer()
        {
            _values = Enum
                .GetNames(typeof(T))
                .OrderBy(x => (int) Enum.Parse(typeof(T), x))
                .ToList();
            
            var lowest = Convert.ToInt32(Enum.Parse(typeof(T), _values.First()));
            _offset = -lowest;
        }
        
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var container = new VisualElement();

            var value = property.intValue + _offset;

            var popup = new PopupField<string>("Value", _values, value);
            popup.RegisterValueChangedCallback(ev =>
            {
                var eValue = (T) Enum.Parse(typeof(T), ev.newValue);
                property.intValue = Convert.ToInt32(eValue);
                property.serializedObject.ApplyModifiedProperties();
            });
            container.Add(popup);
            
            return container;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var mValue = property.intValue;
            property.intValue = (int) (object) EditorGUI.EnumPopup(position, (T) (object) mValue);
            property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}