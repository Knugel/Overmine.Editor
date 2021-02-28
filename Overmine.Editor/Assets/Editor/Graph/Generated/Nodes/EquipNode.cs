/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Equip")]
    public class EquipNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Equip";

        public override System.Type Type => typeof(Thor.Equip);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.EquipmentExt m_equipment;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

    }
}
