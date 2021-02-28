/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Keep Away")]
    public class KeepAwayNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Keep Away";

        public override System.Type Type => typeof(Thor.KeepAway);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("From")]
        public Thor.SharedEntity m_from;

        [GraphProcessor.Input("Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_distance;

        [GraphProcessor.Input("Leash"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_leash;

    }
}
