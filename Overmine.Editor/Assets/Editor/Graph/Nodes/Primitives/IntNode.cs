using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/Integer")]
    public class IntNode : BaseNode
    {
        [Output("Out")]
        public SharedInt Output;

        public override string name => "Integer";
    }
}