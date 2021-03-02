/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Donate")]
    public class DonateNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Donate";

        public override System.Type Type => typeof(Thor.Donate);

        [GraphProcessor.Input("Avatar")]
        public Thor.SharedEntity m_avatar;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Resource")]
        public Thor.ResourceData m_resource;

        [GraphProcessor.Input("Amount Output")]
        public BehaviorDesigner.Runtime.SharedInt m_amountOutput;

    }
}
