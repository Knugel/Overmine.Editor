using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BehaviorDesigner.Runtime;
using Editor.Serialization;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Action = System.Action;
using TooltipAttribute = BehaviorDesigner.Runtime.Tasks.TooltipAttribute;

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
            var element = iterator.FindPropertyRelative("Data");
            var elementType = GetType(element.managedReferenceFullTypename);

            element.NextVisible(true);

            var container = new VisualElement();
            container.AddToClassList("container");

            do
            {
                var field = new PropertyField();
                field.BindProperty(element);

                var tooltip = GetTooltipAttribute(element, true);
                if (tooltip != null)
                    field.tooltip = tooltip.Tooltip;

                if (element.name == "friendlyName")
                {
                    field.RegisterCallback<ChangeEvent<string>>(x => { _inspectorObject.Selected.title = x.newValue; });
                }

                container.Add(field);
            } while (element.NextVisible(false));

            CreateSharedVariableUI(elementType, _inspectorObject.Selected.Data, container);

            _root.Add(container);
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
                        var target= fInfo.GetValue(obj) ?? NodeSerializer.CreateTypeInstance(fInfo.FieldType);
                        fInfo.SetValue(obj, target);

                        var name = $"unity-foldout-Selected.Data.{fInfo.Name}";
                        var existing = container.Q(name);
                        
                        if (existing != null)
                        {
                            if(NodeSerializer.IsTaskReference(fInfo.FieldType))
                                CreateTaskReferenceUI(fInfo.FieldType, fInfo, obj, existing);
                            else
                                CreateSharedVariableUI(fInfo.FieldType, target, existing);
                        }
                        else
                        {
                            existing = new Foldout
                            {
                                text = ObjectNames.NicifyVariableName(fInfo.Name)
                            };

                            if(NodeSerializer.IsTaskReference(fInfo.FieldType))
                                CreateTaskReferenceUI(fInfo.FieldType, fInfo, obj, existing);
                            else
                                CreateSharedVariableUI(fInfo.FieldType, target, existing);
                            
                            if (existing.childCount > 0)
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
                var tooltip = fInfo.GetCustomAttribute<TooltipAttribute>();
                if (tooltip != null)
                {
                    popup.tooltip = tooltip.Tooltip;
                }
                
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

        private void CreateTaskReferenceUI(Type type, FieldInfo fInfo, object obj, VisualElement container)
        {
            var innerType = type.IsArray ? type.GetElementType() : type;
            
            var tasks = _inspectorObject?.View?.GetNodesOfType(innerType).ToList();
            if (tasks == null)
                return;
            
            if (type.IsArray)
            {
                var existing = fInfo.GetValue(obj) as Array;
                
                var size = new IntegerField("Size");
                if (existing != null)
                {
                    size.SetValueWithoutNotify(existing.Length);
                }
                
                container.Add(size);

                size.RegisterValueChangedCallback(ev =>
                {
                    var value = ev.newValue;
                    if (value < 0)
                    {
                        value = 0;
                        size.SetValueWithoutNotify(value);
                    }

                    existing = fInfo.GetValue(obj) as Array;
                    var array = Array.CreateInstance(innerType, value);
                    
                    if(existing != null)
                        Array.Copy(existing, array, Math.Min(existing.Length, array.Length));
                    
                    fInfo.SetValue(obj, array);
                    container.MarkDirtyRepaint();
                });
                
                tasks.Insert(0, null);
                Func<VisualElement> makeItem = () => new PopupField<TaskNode>("", tasks, 0, node => node?.title ?? "None", node => node?.title ?? "None");
                Action<VisualElement, int> bindItem = (e, i) =>
                {
                    var popup = e as PopupField<TaskNode>;
                    popup.RegisterValueChangedCallback(ev =>
                    {
                        existing.SetValue(ev.newValue?.Data, i);
                    });
                    
                    var item = existing.GetValue(i);
                    var node = tasks.FirstOrDefault(x => x?.Data == item);
                    popup.SetValueWithoutNotify(node);
                };

                var listView = new ListView(existing, 19, makeItem, bindItem);
                
                listView.style.height = Math.Min(19 * existing.Length, 75);
                
                container.Add(listView);
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

        private TooltipAttribute GetTooltipAttribute(SerializedProperty prop, bool inherit) {
            if (prop == null) { return null; }
            
            // Remove the Selected.Data. part of the path because we already traversed it.
            var path = prop.propertyPath.Substring(14);
            
            FieldInfo fInfo = null;
            var type = _inspectorObject.Selected.Data.GetType();

            foreach (var name in path.Split('.'))
            {
                var fields = NodeSerializer.GetSerializedFields(type);
                fInfo = fields.FirstOrDefault(x => x.Name == name);
                if (fInfo == null)
                    return null;
                type = fInfo.FieldType;
            }

            return fInfo?.GetCustomAttribute<TooltipAttribute>();
        }

        public override VisualElement CreateInspectorGUI() => _root;
    }
    
    public class InspectorObject : ScriptableObject
    {
        public TaskNode Selected;

        public BehaviourGraphView View;

        public Action SelectionChanged;

        public void UpdateSelection(IEnumerable<TaskNode> nodes)
        {
            Selected = nodes.FirstOrDefault();
            SelectionChanged?.Invoke();
        }
    }
}