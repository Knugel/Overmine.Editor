/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Stop Ability")]
    public class StopAbilityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Stop Ability";

        public override System.Type Type => typeof(Thor.StopAbility);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

    }
}
