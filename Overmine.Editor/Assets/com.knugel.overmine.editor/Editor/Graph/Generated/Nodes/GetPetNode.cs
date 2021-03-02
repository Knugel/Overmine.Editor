/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Pet")]
    public class GetPetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Pet";

        public override System.Type Type => typeof(Thor.GetPet);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.PetOwnerExt.PetSlotType m_slot;

        [GraphProcessor.Input("Pet Output")]
        public Thor.SharedEntity m_petOutput;

    }
}
