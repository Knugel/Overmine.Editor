using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/Float")]
    public class FloatNode : BaseNode
    {
        [Output("Out")]
        public SharedFloat Output;

        public override string name => "Float";
    }
}