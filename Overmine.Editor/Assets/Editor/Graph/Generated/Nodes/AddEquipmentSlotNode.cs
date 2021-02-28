/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Equipment Slot")]
    public class AddEquipmentSlotNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Equipment Slot";

        public override System.Type Type => typeof(Thor.AddEquipmentSlot);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

        [GraphProcessor.Input("Group Index"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_groupIndex;

    }
}
