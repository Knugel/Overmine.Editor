/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Launch")]
    public class LaunchNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Launch";

        public override System.Type Type => typeof(Thor.Launch);

        [GraphProcessor.Input("Launchee")]
        public Thor.SharedEntity m_launchee;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

        [GraphProcessor.Input("Min Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_minAngle;

        [GraphProcessor.Input("Max Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_maxAngle;

        [GraphProcessor.Input("Walkable"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_walkable;

    }
}
