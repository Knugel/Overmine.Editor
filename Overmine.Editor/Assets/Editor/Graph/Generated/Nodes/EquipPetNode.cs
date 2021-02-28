/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Equip Pet")]
    public class EquipPetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Equip Pet";

        public override System.Type Type => typeof(Thor.EquipPet);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Pet")]
        public Thor.SharedEntity m_pet;

        [GraphProcessor.ShowInInspector]
        public Thor.PetOwnerExt.PetSlotType m_slot;

    }
}
