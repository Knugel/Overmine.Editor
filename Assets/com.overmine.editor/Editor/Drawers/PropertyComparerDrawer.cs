using System.Collections.Generic;
using Thor;
using UnityEditor;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(PropertyComparer))]
    public class PropertyComparerDrawer : ThorPropertyDrawer
    {
        private static readonly List<string> Comparisons = new List<string>
        {
            "==",
            "!=",
            ">",
            ">=",
            "<",
            "<=",
            "Contains",
            "DoesNotContain"
        };

        protected override VisualElement Repaint(SerializedProperty property)
        {
            var container = new Foldout
            {
                text = property.displayName
            };

            var lhsDynamic = property.FindPropertyRelative("lhsDynamic");
            var rhsDynamic = property.FindPropertyRelative("rhsDynamic");

            var isLhsDynamic = lhsDynamic.boolValue;
            var isRhsDynamic = rhsDynamic.boolValue;
            
            container.Add(CreatePropertyField(lhsDynamic));
            container.Add(CreatePropertyField(rhsDynamic));

            var lhsType = property.FindPropertyRelative("lhsTypeName");
            var rhsType = property.FindPropertyRelative("rhsTypeName");
            
            if(isLhsDynamic)
                container.Add(CreateTypePopup(lhsType));
            if(isRhsDynamic)
                container.Add(CreateTypePopup(rhsType));
            
            if(isLhsDynamic)
                container.Add(CreatePropertyPopup(property.FindPropertyRelative("lhsMemberName"), lhsType.stringValue));
            if(isRhsDynamic)
                container.Add(CreatePropertyPopup(property.FindPropertyRelative("rhsMemberName"), rhsType.stringValue));
            
            container.Add(CreateOperatorPopup(property.FindPropertyRelative("comparisonName"), Comparisons));
            
            if(!isLhsDynamic)
                container.Add(CreatePropertyField(property.FindPropertyRelative("lhsValue")));
            if(!isRhsDynamic)
                container.Add(CreatePropertyField(property.FindPropertyRelative("rhsValue")));

            return container;
        }
    }
}