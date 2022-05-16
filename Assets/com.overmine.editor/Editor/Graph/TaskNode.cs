using System;
using System.Reflection;
using BehaviorDesigner.Runtime.Tasks;
using Editor.Serialization.Converters;
using Newtonsoft.Json;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;
using Action = BehaviorDesigner.Runtime.Tasks.Action;

namespace Overmine.Editor.Graph
{
    [Serializable]
    public class TaskNode : Node
    {
        [JsonIgnore]
        public string GUID;
        
        public Type Type;

        [SerializeReference]
        public Task Data;

        public VisualElement topPortContainer;
        
        public VisualElement bottomPortContainer;

        public Port Input;

        public Port Output;

        public TaskNode(Type type)
        {
            GUID = Guid.NewGuid().ToString();
            title = ObjectNames.NicifyVariableName(type.Name);
            tooltip = type.GetCustomAttribute<TaskDescriptionAttribute>()?.Description;
            
            Type = type;
            Data = Activator.CreateInstance(Type) as Task;
            Data.FriendlyName = title;
            
            InitView();
        }

        private void InitView()
        {
            styleSheets.Add(Resources.Load<StyleSheet>("Styles/Node"));

            if (!(Data is EntryTask))
            {
                topPortContainer = new VisualElement { name = "TopPortContainer" };
                Insert(0, topPortContainer);
                
                Input = CreatePort(Direction.Input, Port.Capacity.Single);
            }

            if (Data is ParentTask pTask)
            {
                bottomPortContainer = new VisualElement { name = "BottomPortContainer" };
                Add(bottomPortContainer);
                
                Output = CreatePort(Direction.Output, pTask.MaxChildren() == 1 ? Port.Capacity.Single : Port.Capacity.Multi);
            }

            var container = this.Q("node-border");
            container.style.borderLeftWidth = 2;
            container.style.marginRight = 2;
            
            switch (Data)
            {
                case EntryTask _:
                    container.style.borderLeftColor = new Color(0.34f, 0.46f, 0.56f);
                    break;
                case Decorator _:
                    container.style.borderLeftColor = new Color(0.26f, 0.67f, 0.55f);
                    break;
                case Conditional _:
                    container.style.borderLeftColor = new Color(0.98f, 0.78f, 0.31f);
                    break;
                case Action _:
                    container.style.borderLeftColor = new Color(0.98f, 0.25f, 0.27f);
                    break;
                case Composite _:
                    container.style.borderLeftColor = new Color(0.15f, 0.49f, 0.63f);
                    break;
            }
        }

        private Port CreatePort(Direction direction, Port.Capacity capacity)
        {
            var port = Port.Create<Edge>(Orientation.Vertical, direction, capacity, typeof(int));
            port.portName = "";
            
            var portLabel = port.Q("type");
            port.Remove(portLabel);

            var portConnector = port.Q("connector");
            portConnector.pickingMode = PickingMode.Position;
            
            if(direction == Direction.Input)
                topPortContainer.Add(port);
            else
                bottomPortContainer.Add(port);

            RefreshExpandedState();
            return port;
        }
    }
}