/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fast Travel")]
    public class FastTravelNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fast Travel";

        public override System.Type Type => typeof(Thor.FastTravel);

        [GraphProcessor.Input("Avatar")]
        public Thor.SharedEntity m_avatar;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Zones Skipped Output")]
        public BehaviorDesigner.Runtime.SharedInt m_zonesSkippedOutput;

        [GraphProcessor.Input("Warp Data Output")]
        public Thor.SharedDataObject m_warpDataOutput;

    }
}
