/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove Status Effect")]
    public class RemoveStatusEffectNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove Status Effect";

        public override System.Type Type => typeof(Thor.RemoveStatusEffect);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Status Effect")]
        public Thor.SharedEntity m_statusEffect;

        [GraphProcessor.Input("Force"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_force;

        [GraphProcessor.Input("Drop"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_drop;

        [GraphProcessor.Input("Shatter"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_shatter;

        [GraphProcessor.Input("Dropped Output")]
        public Thor.SharedEntity m_droppedOutput;

    }
}
