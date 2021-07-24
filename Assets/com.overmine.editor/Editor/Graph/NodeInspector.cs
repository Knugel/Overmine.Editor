using System;
using System.Collections.Generic;
using System.Linq;
using BehaviorDesigner.Runtime;
using Editor.Serialization;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Overmine.Editor.Graph
{
    [CustomEditor(typeof(InspectorObject))]
    public class NodeInspector : UnityEditor.Editor
    {
        private InspectorObject _inspectorObject;
        private VisualElement _root;

        private void OnEnable()
        {
            _inspectorObject = target as InspectorObject;
            _inspectorObject.SelectionChanged += SelectionChanged;

            _root = new VisualElement();
            _root.styleSheets.Add(Resources.Load<StyleSheet>("Styles/NodeInspector"));
            
            SelectionChanged();
        }

        private void OnDisable()
        {
            _inspectorObject.SelectionChanged -= SelectionChanged;
        }

        private void SelectionChanged()
        {
            _root.Clear();
            serializedObject.Update();
            
            var iterator = serializedObject.FindProperty("Selected");
            if (iterator == null)
                return;
            iterator.Next(true);

            for (var i = 0; i < iterator.arraySize; i++)
            {
                var node = iterator.GetArrayElementAtIndex(i);
                var element = node.FindPropertyRelative("Data");
                var elementType = GetType(element.managedReferenceFullTypename);
                
                element.NextVisible(true);

                var container = new VisualElement();
                container.AddToClassList("container");

                do
                {
                    var field = new PropertyField();
                    field.BindProperty(element);
                    container.Add(field);
                } while (element.NextVisible(false));
                
                CreateSharedVariableUI(elementType, _inspectorObject.Selected[0].Data, container);

                _root.Add(container);
            }
        }

        private void CreateSharedVariableUI(Type type, object obj, VisualElement container)
        {
            var fields = NodeSerializer.GetSerializedFields(type);
            foreach (var fInfo in fields)
            {
                var foldout = new Foldout
                {
                    text = ObjectNames.NicifyVariableName(fInfo.Name)
                };
                
                if (fInfo.FieldType != typeof(SharedVariable))
                {
                    if (fInfo.FieldType.IsSerializable && !fInfo.FieldType.IsAbstract && !fInfo.FieldType.Namespace.StartsWith("System"))
                    {
                        var target= fInfo.GetValue(obj) ?? CreateTypeInstance(fInfo.FieldType);
                        fInfo.SetValue(obj, target);

                        var name = $"unity-foldout-Selected.Array.data[0].Data.{fInfo.Name}";
                        var existing = container.Q(name);

                        if (existing != null)
                        {
                            CreateSharedVariableUI(fInfo.FieldType, target, existing);
                        }
                        else
                        {
                            existing = new Foldout
                            {
                                text = ObjectNames.NicifyVariableName(fInfo.Name)
                            };

                            CreateSharedVariableUI(fInfo.FieldType, target, existing);
                            if(existing.childCount > 0)
                                container.Add(existing);
                        }
                        
                        existing.MarkDirtyRepaint();
                    }
                    continue;
                }
                
                var choices = _inspectorObject?.View?.Properties?.Select(x => x.Name).ToList() ?? new List<string>();
                choices.Insert(0, "None");

                var value = fInfo.GetValue(obj) as SharedVariable;

                var index = choices.IndexOf(value?.Name);
                if (index < 0)
                    index = 0;

                var popup = new PopupField<string>("Variable", choices, index);
                popup.RegisterValueChangedCallback(ev =>
                {
                    if (value == null)
                    {
                        var propType = _inspectorObject.View.Properties.FirstOrDefault(x => x.Name == ev.newValue)?.Type;
                        if (propType != null)
                        {
                            value = Activator.CreateInstance(propType) as SharedVariable;
                        }
                    }
                        
                    value.Name = ev.newValue;
                    value.IsShared = value.Name != "None";
                    fInfo.SetValue(obj, value);
                    serializedObject.ApplyModifiedProperties();
                });
                foldout.Add(popup);
                container.Add(foldout);
            }
        }

        private Type GetType(string fullName)
        {
            var split = fullName.Split(' ');
            var assembly = split[0];
            var typeName = split[1];
            return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.GetName().Name == assembly)
                ?.GetType(typeName);
        }

        private static object CreateTypeInstance(Type type)
        {
            if (type.IsArray)
                return Array.CreateInstance(type.GetElementType(), 0);
            return Activator.CreateInstance(type);
        }

        public override VisualElement CreateInspectorGUI() => _root;
    }
    
    public class InspectorObject : ScriptableObject
    {
        public List<TaskNode> Selected = new List<TaskNode>();

        public BehaviourGraphView View;

        public Action SelectionChanged;

        public void UpdateSelection(IEnumerable<TaskNode> nodes)
        {
            Selected = nodes.Take(1).ToList();
            SelectionChanged?.Invoke();
        }
    }
}