using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(LocID))]
    public class LocIDDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            
            var mValue = property.FindPropertyRelative("m_text.mValue");
            mValue.stringValue = EditorGUI.TextField(position, mValue.stringValue);
            property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }
    }
}