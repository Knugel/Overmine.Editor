/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Seek")]
    public class SeekNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Seek";

        public override System.Type Type => typeof(Thor.Seek);

        [GraphProcessor.Input("Projectile")]
        public Thor.SharedEntity m_projectile;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_distance;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

        [GraphProcessor.Input("Timeout"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_timeout;

    }
}
