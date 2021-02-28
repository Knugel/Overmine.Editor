/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Damage Type")]
    public class CompareDamageTypeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Damage Type";

        public override System.Type Type => typeof(Thor.CompareDamageType);

        [GraphProcessor.Input("Damage Type"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedDamageType m_damageType;

        [GraphProcessor.Input("Compare To"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedDamageType m_compareTo;

    }
}
