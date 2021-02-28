/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Follow")]
    public class FollowNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Follow";

        public override System.Type Type => typeof(Thor.Follow);

        [GraphProcessor.Input("Follower")]
        public Thor.SharedEntity m_follower;

        [GraphProcessor.Input("Follow Target")]
        public Thor.SharedEntity m_followTarget;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

    }
}
