using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BehaviorDesigner.Runtime;
using Thor;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(PropertySetter))]
    public class PropertySetterDrawer : ThorPropertyDrawer
    {
        private static readonly List<string> Operators = new List<string>
        {
            "=",
            "+=",
            "-=",
            "*=",
            "/="
        };
        
        protected override VisualElement Repaint(SerializedProperty property)
        {
            var container = new Foldout()
            {
                text = property.displayName
            };

            var typeName = property.FindPropertyRelative("typeName");
            var memberName = property.FindPropertyRelative("memberName");
            var operatorName = property.FindPropertyRelative("operatorName");

            container.Add(CreateTypePopup(typeName));
            container.Add(CreatePropertyPopup(memberName, typeName.stringValue));
            
            var propertyInfo = GetProperty(typeName.stringValue, memberName.stringValue);
            var operators = Operators;

            if (propertyInfo?.PropertyType.IsNumeric() == false)
            {
                operators = operators.Take(1).ToList();
                operatorName.stringValue = operators.First();
                
                property.serializedObject.ApplyModifiedProperties();
                property.serializedObject.Update();
            }

            container.Add(CreateOperatorPopup(operatorName, operators));
            container.Add(CreateValueField(property, propertyInfo));
            
            return container;
        }

        private VisualElement CreateValueField(SerializedProperty property, PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
                return new VisualElement();

            if (propertyInfo.PropertyType == typeof(bool))
                return CreatePropertyField(property.FindPropertyRelative("boolValue"));
            if (propertyInfo.PropertyType == typeof(float))
                return CreatePropertyField(property.FindPropertyRelative("floatValue"));
            if (propertyInfo.PropertyType.IsNumeric())
                return CreatePropertyField(property.FindPropertyRelative("intValue"));
            if (propertyInfo.PropertyType == typeof(Vector3))
                return CreatePropertyField(property.FindPropertyRelative("vector3Value"));
            if(typeof(Entity).IsAssignableFrom(propertyInfo.PropertyType))
                return CreatePropertyField(property.FindPropertyRelative("entityValue"));
            if (propertyInfo.PropertyType == typeof(Color))
                return CreatePropertyField(property.FindPropertyRelative("colorValue"));
            if(typeof(DataObject).IsAssignableFrom(propertyInfo.PropertyType))
                return CreatePropertyField(property.FindPropertyRelative("dataObjectValue"));
            if (propertyInfo.PropertyType == typeof(string))
                return CreatePropertyField(property.FindPropertyRelative("stringValue"));

            return new VisualElement();
        }

        private PropertyInfo GetProperty(string typeName, string memberName)
        {
            var type = string.IsNullOrEmpty(typeName) ? null : TaskUtility.GetTypeWithinAssembly(typeName);
            var propertyInfo = GetBehaviorProperties(type).FirstOrDefault(x => x.Name == memberName);
            return propertyInfo;
        }
    }
}