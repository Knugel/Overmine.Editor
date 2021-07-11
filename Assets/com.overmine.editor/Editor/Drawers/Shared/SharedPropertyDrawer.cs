using BehaviorDesigner.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Drawers.Shared
{
    public class SharedPropertyDrawer<T> : PropertyDrawer where T : SharedVariable
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var container = new VisualElement();
            var foldout = new Foldout
            {
                text = property.displayName
            };
            
            var valueField = new PropertyField { label = "Value" };
            valueField.BindProperty(property.FindPropertyRelative("mValue"));

            foldout.Add(new VariablePopup<T>(property));
            foldout.Add(valueField);
            
            container.Add(foldout);
            return container;
        }
    }
}