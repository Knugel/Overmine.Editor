/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Rumble")]
    public class RumbleNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Rumble";

        public override System.Type Type => typeof(Thor.Rumble);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_amount;

        [GraphProcessor.Input("Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_duration;

    }
}
