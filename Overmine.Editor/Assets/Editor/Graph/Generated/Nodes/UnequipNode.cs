/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unequip")]
    public class UnequipNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unequip";

        public override System.Type Type => typeof(Thor.Unequip);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

        [GraphProcessor.Input("Drop"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_drop;

        [GraphProcessor.Input("Dropped Output")]
        public Thor.SharedEntity m_droppedOutput;

    }
}
