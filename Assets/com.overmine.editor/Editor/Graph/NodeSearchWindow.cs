using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BehaviorDesigner.Runtime.Tasks;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Overmine.Editor.Graph
{
    public class NodeSearchWindow : ScriptableObject, ISearchWindowProvider
    {
        private readonly List<Type> _taskNodes;

        private Texture2D _indentationIcon;
        
        private BehaviourGraphView _graphView;
        private EditorWindow _window;

        public NodeSearchWindow()
        {
            _taskNodes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => FindDerivedTypes(x, typeof(Task))).ToList();
        }
        
        public void Init(EditorWindow window, BehaviourGraphView graphView)
        {
            _window = window;
            _graphView = graphView;
            
            _indentationIcon = new Texture2D(1, 1);
            _indentationIcon.SetPixel(0, 0, new Color(0, 0, 0, 0));
            _indentationIcon.Apply();
        }
        
        public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
        {
            var tree = new List<SearchTreeEntry>()
            {
                new SearchTreeGroupEntry(new GUIContent("Create Node"), 0)
            };
            
            foreach (var entry in _taskNodes
                .GroupBy(x => x.GetCustomAttribute<TaskCategoryAttribute>()?.Category)
                .OrderBy(x => x.Key))
            {
                tree.Add(new SearchTreeGroupEntry(new GUIContent(entry.Key ?? "Miscellaneous"), 1));
                
                foreach (var child in entry)
                {
                    if(child.IsAbstract)
                        continue;

                    tree.Add(new SearchTreeEntry(new GUIContent(ObjectNames.NicifyVariableName(child.Name), _indentationIcon))
                    {
                        level = 2,
                        userData = child
                    });
                }
            }
            
            return tree;
        }

        public bool OnSelectEntry(SearchTreeEntry entry, SearchWindowContext context)
        {
            var position = _window.rootVisualElement.ChangeCoordinatesTo(_window.rootVisualElement.parent,
                context.screenMousePosition - _window.position.position);
            _graphView.CreateNode(entry.userData as Type, position);
            return true;
        }
        
        private IEnumerable<Type> FindDerivedTypes(Assembly assembly, Type baseType)
        {
            return assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));
        }
    }
}