using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Target Data")]
    public class TargetDataNode : BaseNode
    {
        [ShowInInspector]
        public TargetData.TargetType Type = TargetData.TargetType.None;
        
        [Input("Target")]
        public SharedEntity Target;
        
        [Input("Position"), ShowAsDrawer]
        public SharedVector3 Position;
        
        [Input("Direction"), ShowAsDrawer]
        public SharedVector3 Direction;

        [Output("Out")] 
        public TargetData Output;

        public override string name => "Target Data";
        
        protected override void Process()
        {
            Output = new TargetData
            {
                type = Type,
                target = Target,
                position = Position,
                direction = Direction
            };
        }
    }
}