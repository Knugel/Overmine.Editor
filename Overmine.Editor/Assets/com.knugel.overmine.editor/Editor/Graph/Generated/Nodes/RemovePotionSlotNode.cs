/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove Potion Slot")]
    public class RemovePotionSlotNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove Potion Slot";

        public override System.Type Type => typeof(Thor.RemovePotionSlot);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
