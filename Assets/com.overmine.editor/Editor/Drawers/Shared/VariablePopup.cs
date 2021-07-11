using System.Collections.Generic;
using System.Linq;
using BehaviorDesigner.Runtime;
using Overmine.Editor.Graph;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Drawers
{
    public class VariablePopup<T> : VisualElement where T : SharedVariable
    {
        public VariablePopup(SerializedProperty property)
        {
            var inspector = property.serializedObject.targetObject as InspectorObject;
            var choices = inspector?.View?.Properties?
                .Where(x => typeof(T).IsAssignableFrom(x.Type))
                .Select(x => x.Name)
                .ToList() ?? new List<string>();
            choices.Insert(0, "None");

            var mName = property.FindPropertyRelative("mName");
            if (mName == null)
            {
                Debug.LogWarning($"Couldn't find Name property in SharedVariable '{property.propertyPath}'!");
                return;
            }

            var index = choices.IndexOf(mName.stringValue);
            if (index < 0)
                index = 0;

            var popup = new PopupField<string>("Variable", choices, index);

            popup.RegisterValueChangedCallback(ev =>
            {
                mName.stringValue = ev.newValue == "None" ? null : ev.newValue;
                
                var mShared = property.FindPropertyRelative("mIsShared");
                mShared.boolValue = mName.stringValue != null;
                
                property.serializedObject.ApplyModifiedProperties();
            });
            
            Add(popup);
        }
    }
}