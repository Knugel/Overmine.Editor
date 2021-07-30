using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BehaviorDesigner.Runtime;
using Thor;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    public abstract class ThorPropertyDrawer : PropertyDrawer
    {
        private static readonly List<string> Types = FindTypes();
        
        protected readonly VisualElement Root;
        protected SerializedProperty Property;

        protected ThorPropertyDrawer()
        {
            Root = new VisualElement();
        }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            Property = property;
            Root.Clear();
            Root.Add(Repaint(Property));
            return Root;
        }

        protected abstract VisualElement Repaint(SerializedProperty property);
        
        protected VisualElement CreatePropertyField(SerializedProperty property)
        {
            var field = new PropertyField();
            field.BindProperty(property);
            field.RegisterCallback<ChangeEvent<bool>>(x =>
            {
                CreatePropertyGUI(Property);
            });
            return field;
        }
        
        protected VisualElement CreateTypePopup(SerializedProperty property)
        {
            var value = string.IsNullOrEmpty(property.stringValue) ? "None" : property.stringValue;
            if (!Types.Contains(value))
                value = "None";
            
            var popup = new PopupField<string>(Types, value);
            popup.label = property.displayName;
            popup.RegisterValueChangedCallback(ev =>
            {
                property.stringValue = ev.newValue == "None" ? null : ev.newValue;
                property.serializedObject.ApplyModifiedProperties();
                property.serializedObject.Update();
                CreatePropertyGUI(Property);
            });
            return popup;
        }

        protected VisualElement CreatePropertyPopup(SerializedProperty property, string typeName)
        {
            var type = string.IsNullOrEmpty(typeName) ? null : TaskUtility.GetTypeWithinAssembly(typeName);
            var choices = GetBehaviorProperties(type).Select(x => x.Name).ToList();
            choices.Insert(0, "None");

            var name = string.IsNullOrEmpty(property.stringValue) ? "None" : property.stringValue;
            if (!choices.Contains(name))
            {
                name = choices.First();
            }

            var popup = new PopupField<string>(choices, name);
            popup.label = property.displayName;
            popup.RegisterValueChangedCallback(ev =>
            {
                property.stringValue = ev.newValue == "None" ? null : ev.newValue;
                property.serializedObject.ApplyModifiedProperties();
                property.serializedObject.Update();
                CreatePropertyGUI(Property);
            });
            return popup;
        }

        protected VisualElement CreateOperatorPopup(SerializedProperty property, List<string> operators)
        {
            var value = string.IsNullOrEmpty(property.stringValue) ? operators.First() : property.stringValue;

            var popup = new PopupField<string>(operators, SlashToUnicode(value));
            popup.label = property.displayName;
            popup.RegisterValueChangedCallback(ev =>
            {
                property.stringValue = SlashFromUnicode(ev.newValue);
                property.serializedObject.ApplyModifiedProperties();
                property.serializedObject.Update();
            });
            return popup;
        }

        private string SlashToUnicode(string source)
        {
            return source.Replace('/', '\u2044');
        }

        private string SlashFromUnicode(string source)
        {
            return source.Replace('\u2044', '/');
        }
        
        private static List<string> FindTypes()
        {
            var types = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetExportedTypes())
                .Where(x => x?.Namespace?.StartsWith("Thor") ?? false)
                .Where(x => GetBehaviorProperties(x).Any())
                .Select(x => $"{x.Namespace}.{x.Name}")
                .OrderBy(x => x)
                .ToList();
            types.Insert(0, "None");
            return types;
        }
        
        protected static IEnumerable<PropertyInfo> GetBehaviorProperties(Type type)
        {
            if (type == null)
                return Enumerable.Empty<PropertyInfo>();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            return properties.Where(x => x.GetCustomAttribute<BehaviorProperty>() != null).ToList();
        }
    }
}