/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unequip Active Potion")]
    public class UnequipActivePotionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unequip Active Potion";

        public override System.Type Type => typeof(Thor.UnequipActivePotion);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
