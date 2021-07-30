using Thor;
using UnityEditor;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(PropertyObserver))]
    public class PropertyObserverDrawer : ThorPropertyDrawer
    {
        protected override VisualElement Repaint(SerializedProperty property)
        {
            var container = new Foldout()
            {
                text = property.displayName
            };
            
            var typeName = property.FindPropertyRelative("lhsTypeName");
            var memberName = property.FindPropertyRelative("lhsMemberName");

            container.Add(CreateTypePopup(typeName));
            container.Add(CreatePropertyPopup(memberName, typeName.stringValue));
            
            return container;
        }
    }
}