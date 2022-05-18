using System;
using System.Collections.Generic;
using System.Linq;
using BehaviorDesigner.Runtime.Tasks;
using Editor.Serialization;
using Overmine.API.Assets;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Overmine.Editor.Graph
{
    public class BehaviourGraphView : GraphView
    {
        public Blackboard Blackboard;
        
        private readonly NodeSearchWindow _searchWindow;
        public readonly List<ExposedProperty> Properties;
        
        [NonSerialized]
        private InspectorObject _inspectorObject;

        private BehaviourGraph _graph;

        public BehaviourGraphView(EditorWindow window, BehaviourGraph graph)
        {
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
            
            this.AddManipulator(new ContentDragger());
            this.AddManipulator(new SelectionDragger());
            this.AddManipulator(new RectangleSelector());
            this.AddManipulator(new FreehandSelector());

            graphViewChanged = OnGraphViewChanged;

            _graph = graph;
            
            _searchWindow = ScriptableObject.CreateInstance<NodeSearchWindow>();
            _searchWindow.Init(window, this);
            nodeCreationRequest = context =>
                SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), _searchWindow);

            _inspectorObject = ScriptableObject.CreateInstance<InspectorObject>();
            _inspectorObject.name = "Node Inspector";
            _inspectorObject.hideFlags = HideFlags.HideAndDontSave ^ HideFlags.NotEditable;
            _inspectorObject.View = this;

            Properties = new List<ExposedProperty>();
            
            RegisterCallback<MouseUpEvent>(OnMouseUp);
            RegisterCallback<MouseDownEvent>(OnMouseDown);
            
            RegisterCallback<KeyDownEvent>(OnKeyDown);

            styleSheets.Add(Resources.Load<StyleSheet>("Styles/GraphView"));
            
            Insert(0, new GridBackground());
            
            Undo.undoRedoPerformed += UpdateInspectorSelection;
        }

        private GraphViewChange OnGraphViewChanged(GraphViewChange changes)
        {
            if (changes.elementsToRemove == null)
                return changes;
            
            changes.elementsToRemove.Sort((e1, e2) => {
                int GetPriority(GraphElement e)
                {
                    return e is TaskNode ? 0 : 1;
                }
                return GetPriority(e1).CompareTo(GetPriority(e2));
            });
            
            changes.elementsToRemove.RemoveAll(e =>
            {
                switch (e)
                {
                    case Edge edge:
                        Disconnect(edge);
                        return true;
                    case TaskNode node:
                        foreach(var edge in node.Input?.connections?.ToList() ?? Enumerable.Empty<Edge>())
                            Disconnect(edge);
                        foreach(var edge in node.Output?.connections?.ToList() ?? Enumerable.Empty<Edge>())
                            Disconnect(edge);
                        return false;
                    case BlackboardField field:
                        Properties.RemoveAll(x => x.Name == field.text);
                        return false;
                }
                return false;
            });
            return changes;
        }

        private void OnKeyDown(KeyDownEvent evt)
        {
            if(evt.ctrlKey && evt.keyCode == KeyCode.S)
                Save(_graph);
        }

        private void OnMouseDown(MouseDownEvent evt)
        {
            if (IsNodeSelected())
                UpdateInspectorSelection();
            else
                ClearInspectorSelection();
        }

        private void OnMouseUp(MouseUpEvent evt)
        {
            schedule.Execute(() =>
            {
                if (IsNodeSelected())
                    UpdateInspectorSelection();
                else
                    ClearInspectorSelection();
            }).ExecuteLater(1);
        }

        public TaskNode CreateNode(Type type, Vector2 position)
        {
            var entry = new TaskNode(type);
            entry.SetPosition(new Rect(position, new Vector2(0, 0)));
            AddElement(entry);
            return entry;
        }

        public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
        {
            return ports
                .ToList()
                .Where(port => port.direction != startPort.direction && port.node != startPort.node)
                .ToList();
        }

        private void UpdateInspectorSelection()
        {
            _inspectorObject.Selected = null;
            
            var selected = new HashSet<TaskNode>();
            foreach (var node in selection)
            {
                if (node is TaskNode t && Contains(t))
                    selected.Add(t);
            }

            if (selected.Count > 0)
            {
                _inspectorObject.UpdateSelection(selected);
                Selection.activeObject = _inspectorObject;
            }
        }

        private void ClearInspectorSelection()
        {
            _inspectorObject.UpdateSelection(Enumerable.Empty<TaskNode>());
            Selection.activeObject = null;
        }

        private bool IsNodeSelected() => selection.Any(x => x is TaskNode);

        public void AddExposedProperty(ExposedProperty property)
        {
            if (Properties.Any(x => x.Name == property.Name && x.Type == property.Type))
                return;
            
            Properties.Add(property);
            var container = new VisualElement();
            container.Add(new BlackboardField()
            {
                text = property.Name,
                typeText = property.Type.Name,
            });
            Blackboard.Add(container);
        }

        public void Save(BehaviourGraph graph)
        {
            graph.Links.Clear();

            if (graph == null)
                return;

            foreach (var edge in edges.ToList())
            {
                var inputNode = edge.input.node as TaskNode;
                var outputNode = edge.output.node as TaskNode;
                
                graph.Links.Add(new NodeLink
                {
                    SourceGuid = outputNode.GUID,
                    TargetGuid = inputNode.GUID
                });
            }
            
            graph.NodesData.Clear();
            
            foreach (var node in nodes.ToList().Cast<TaskNode>())
            {
                graph.NodesData.Add(new NodeData
                {
                    GUID = node.GUID,
                    Position = node.GetPosition().position,
                    Type = node.Type,
                    Data = node.Data
                });
            }

            var id = 0;
            var entry = graph.NodesData.FirstOrDefault(x => x.Type == typeof(EntryTask));
            if(entry != null)
                AssignID(entry, ref id);

            graph.Variables.Clear();
            
            foreach (var variable in Properties)
            {
                graph.Variables.Add(new Variable
                {
                    Name = variable.Name,
                    Type = variable.Type,
                    IsGlobal = variable.IsGlobal
                });
            }
            
            graph.BehaviorSource.TaskData = NodeSerializer.Serialize(graph);
            
            EditorUtility.SetDirty(graph);
            AssetDatabase.SaveAssets();
        }

        private void AssignID(NodeData node, ref int id)
        {
            node.Data.ID = id++;
            foreach(var child in _graph.GetLinked(node))
                AssignID(child, ref id);
        }

        public void Connect(TaskNode input, TaskNode output)
        {
            var edge = new Edge {input = input.Input, output = output.Output };
            edge.input.Connect(edge);
            edge.output.Connect(edge);
            AddElement(edge);
        }

        public void Disconnect(Edge edge)
        {
            edge.input.Disconnect(edge);
            edge.output.Disconnect(edge);
            RemoveElement(edge);
        }

        public IEnumerable<TaskNode> GetNodesOfType(Type type)
        {
            return nodes.ToList().Cast<TaskNode>().Where(x => type.IsAssignableFrom(x.Type));
        }

        public void Load(BehaviourGraph graph)
        {
            if (graph == null)
                return;

            _graph = graph;
            
            DeleteElements(edges.ToList());
            DeleteElements(nodes.ToList());
            Properties.Clear();
            Blackboard.Clear();

            foreach (var variable in graph.Variables)
            {
                AddExposedProperty(new ExposedProperty
                {
                    Name = variable.Name,
                    Type = variable.Type,
                    IsGlobal = variable.IsGlobal
                });
            }
            
            NodeDeserializer.Deserialize(graph.BehaviorSource.TaskData, this);
        }
    }
}