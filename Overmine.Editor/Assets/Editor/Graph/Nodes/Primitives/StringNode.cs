using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/String")]
    public class StringNode : BaseNode
    {
        [Output("Out")]
        public SharedString Output;

        public override string name => "String";
    }
}