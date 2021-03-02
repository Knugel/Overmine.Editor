/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Zoom")]
    public class ZoomNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Zoom";

        public override System.Type Type => typeof(Thor.Zoom);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_amount;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

        [GraphProcessor.Input("Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_duration;

    }
}
