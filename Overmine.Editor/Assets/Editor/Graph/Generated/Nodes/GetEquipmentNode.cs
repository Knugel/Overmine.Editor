/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Equipment")]
    public class GetEquipmentNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Equipment";

        public override System.Type Type => typeof(Thor.GetEquipment);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
