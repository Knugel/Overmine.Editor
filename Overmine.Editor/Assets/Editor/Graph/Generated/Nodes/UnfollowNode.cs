/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unfollow")]
    public class UnfollowNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unfollow";

        public override System.Type Type => typeof(Thor.Unfollow);

        [GraphProcessor.Input("Follower")]
        public Thor.SharedEntity m_follower;

    }
}
