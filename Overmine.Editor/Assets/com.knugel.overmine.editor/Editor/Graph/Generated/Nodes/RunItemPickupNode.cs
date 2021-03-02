/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Run Item Pickup")]
    public class RunItemPickupNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Run Item Pickup";

        public override System.Type Type => typeof(Thor.RunItemPickup);

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

        [GraphProcessor.ShowInInspector]
        public Thor.RunItemPickup.PickupType m_type;

        [GraphProcessor.Input("Self")]
        public Thor.SharedEntity m_self;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
