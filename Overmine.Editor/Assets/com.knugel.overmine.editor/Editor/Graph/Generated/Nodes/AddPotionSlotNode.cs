/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Potion Slot")]
    public class AddPotionSlotNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Potion Slot";

        public override System.Type Type => typeof(Thor.AddPotionSlot);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
