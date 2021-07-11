using System;
using System.Linq;
using BehaviorDesigner.Runtime;
using Overmine.API.Assets;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Overmine.Editor.Graph
{
    public class BehaviourGraphWindow : GraphViewEditorWindow
    {
        private BehaviourGraphView _graphView;
        private BehaviourGraph _graph;

        [OnOpenAsset(0)]
        public static bool Open(int instanceId, int line, int column)
        {
            var item = EditorUtility.InstanceIDToObject(instanceId);

            if (item is BehaviourGraph graph)
            {
                var window = GetWindow<BehaviourGraphWindow>();
                window.titleContent = new GUIContent("Behaviour Graph");
                window._graph = graph;
                window._graphView.Load(window._graph);
                return true;
            }

            return false;
        }

        private void OnEnable()
        {
            _graphView = new BehaviourGraphView(this, _graph)
            {
                name = "Behaviour Graph"
            };

            var blackboard = new Blackboard(_graphView) { subTitle = "Variables" };
            _graphView.Blackboard = blackboard;

            blackboard.addItemRequested = AddItemRequested;
            blackboard.editTextRequested = EditTextRequested;

            _graphView.Add(blackboard);

            _graphView.StretchToParentSize();
            rootVisualElement.Add(_graphView);
            
            _graphView.Load(_graph);
        }

        private void EditTextRequested(Blackboard blackboard, VisualElement element, string value)
        {
            var name = ((BlackboardField) element).text;
            var old = _graphView.Properties.First(x => x.Name == name);
            old.Name = value;
            ((BlackboardField) element).text = value;
        }

        private void AddItemRequested(Blackboard blackboard)
        {
            var parameterType = new GenericMenu();
            var types = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetExportedTypes())
                .Where(x => typeof(SharedVariable).IsAssignableFrom(x))
                .Where(x => !x.IsAbstract)
                .ToList();

            foreach (var type in types)
            {
                parameterType.AddItem(new GUIContent(type.Name), false, data =>
                {
                    _graphView.AddExposedProperty(new ExposedProperty() { Name = "New Variable", Type = data as Type});
                }, type);
            }
            parameterType.ShowAsContext();
        }

        private void OnDisable()
        {
            rootVisualElement.Remove(_graphView);
        }
    }
}