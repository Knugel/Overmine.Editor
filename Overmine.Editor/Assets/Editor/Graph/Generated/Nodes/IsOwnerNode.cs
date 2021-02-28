/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Is Owner")]
    public class IsOwnerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Is Owner";

        public override System.Type Type => typeof(Thor.IsOwner);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Owner")]
        public Thor.SharedEntity m_owner;

    }
}
