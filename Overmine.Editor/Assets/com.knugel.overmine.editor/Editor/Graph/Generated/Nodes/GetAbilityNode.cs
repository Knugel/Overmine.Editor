/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Ability")]
    public class GetAbilityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Ability";

        public override System.Type Type => typeof(Thor.GetAbility);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
