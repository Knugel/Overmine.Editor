using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/Vector3")]
    public class Vector3Node : BaseNode
    {
        [Output("Out")]
        public SharedVector3 Output;
        
        public override string name => "Vector3";
    }
}