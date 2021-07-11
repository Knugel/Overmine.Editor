using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    public class FlaggedEnumDrawer<T> : PropertyDrawer where T : Enum
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var container = new VisualElement();
            
            var value = property.intValue;

            var popup = new EnumFlagsField("Value", (T) (object) value);
            popup.RegisterValueChangedCallback(ev =>
            {
                property.intValue = (int) (object) ev.newValue;
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
            property.intValue = (int) (object) EditorGUI.EnumFlagsField(position, (T) (object) mValue);
            property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}