/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Owner")]
    public class SetOwnerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Owner";

        public override System.Type Type => typeof(Thor.SetOwner);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Owner")]
        public Thor.SharedEntity m_owner;

    }
}
