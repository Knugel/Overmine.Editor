using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/Vector2")]
    public class Vector2Node : BaseNode
    {
        [Output("Out")]
        public SharedVector2 Output;
        
        public override string name => "Vector2";
    }
}