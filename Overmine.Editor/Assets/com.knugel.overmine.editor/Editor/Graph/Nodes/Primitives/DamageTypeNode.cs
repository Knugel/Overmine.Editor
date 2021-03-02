using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes.Primitives
{
    [System.Serializable, NodeMenuItem("Primitives/Damage Type")]
    public class DamageTypeNode : BaseNode
    {
        [Output("Out")]
        public SharedDamageType Output;

        public override string name => "Damage Type";
    }
}