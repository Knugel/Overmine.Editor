using System.Collections.Generic;
using Thor;
using UnityEditor;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(NumericOpAttribute))]
    public class NumericOperatorDrawer : ThorPropertyDrawer
    {
        private static readonly List<string> Operators = new List<string>
        {
            "=",
            "+=",
            "-=",
            "*=",
            "\u2044="
        };
        
        protected override VisualElement Repaint(SerializedProperty property)
        {
            return CreateOperatorPopup(property, Operators);
        }
    }
}