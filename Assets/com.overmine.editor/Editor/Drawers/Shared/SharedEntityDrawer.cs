using Thor;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedEntity))]
    public class SharedEntityDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var container = new VisualElement();
            var foldout = new Foldout
            {
                text = property.displayName
            };
            
            var objField = new ObjectField("Reference")
            {
                objectType = typeof(Entity),
                allowSceneObjects = false
            };
            var mValue = property.FindPropertyRelative("mValue");
            if (mValue == null)
                return container;
            
            objField.BindProperty(mValue);

            foldout.Add(new VariablePopup<SharedEntity>(property));
            foldout.Add(objField);
            container.Add(foldout);
            
            return container;
        }
    }
}