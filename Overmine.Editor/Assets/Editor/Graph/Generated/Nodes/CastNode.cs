/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Cast")]
    public class CastNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Cast";

        public override System.Type Type => typeof(Thor.Cast);

        [GraphProcessor.Input("Caster")]
        public Thor.SharedEntity m_caster;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

    }
}
