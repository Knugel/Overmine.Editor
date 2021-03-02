/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Attack")]
    public class AttackNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Attack";

        public override System.Type Type => typeof(Thor.Attack);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Attacker")]
        public Thor.SharedEntity m_attacker;

        [GraphProcessor.Input("Origin")]
        public Thor.SharedEntity m_origin;

        [GraphProcessor.Input("Hint"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_hint;

    }
}
