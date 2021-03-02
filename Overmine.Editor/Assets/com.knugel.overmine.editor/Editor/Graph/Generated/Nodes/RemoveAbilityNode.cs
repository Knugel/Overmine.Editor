/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove Ability")]
    public class RemoveAbilityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove Ability";

        public override System.Type Type => typeof(Thor.RemoveAbility);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

    }
}
