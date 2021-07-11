using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BehaviorDesigner.Runtime;
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

                // Very ugly hack to get the non Serializable SharedVariable type to show up in the inspector
                // TODO: Find a better way to do this.
                // BUG: Doesn't currently work with nested SharedVariable types.
                foreach (var fInfo in elementType.GetFields(BindingFlags.Instance | BindingFlags.Public |
                                                            BindingFlags.NonPublic))
                {
                    if(fInfo.FieldType != typeof(SharedVariable))
                        continue;
                    
                    var foldout = new Foldout
                    {
                        text = ObjectNames.NicifyVariableName(fInfo.Name)
                    };
                    var choices = _inspectorObject.View.Properties.Select(x => x.Name).ToList();
                    choices.Insert(0, "None");

                    var value = fInfo.GetValue(_inspectorObject.Selected[0].Data) as SharedVariable;

                    var index = choices.IndexOf(value?.Name);
                    if (index < 0)
                        index = 0;

                    var popup = new PopupField<string>("Variable", choices, index);
                    popup.RegisterValueChangedCallback(ev =>
                    {
                        if (value == null)
                        {
                            var type = _inspectorObject.View.Properties.FirstOrDefault(x => x.Name == ev.newValue)?.Type;
                            if (type != null)
                            {
                                value = Activator.CreateInstance(type) as SharedVariable;
                            }
                        }
                        
                        value.Name = ev.newValue;
                        value.IsShared = value.Name != "None";
                        fInfo.SetValue(_inspectorObject.Selected[0].Data, value);
                        serializedObject.ApplyModifiedProperties();
                    });
                    foldout.Add(popup);
                    container.Add(foldout);
                }

                _root.Add(container);
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