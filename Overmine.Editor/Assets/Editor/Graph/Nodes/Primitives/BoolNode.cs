using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/Boolean")]
    public class BooleanNode : BaseNode
    {
        [Output("Out")]
        public SharedBool Output;

        public override string name => "Boolean";
    }
}