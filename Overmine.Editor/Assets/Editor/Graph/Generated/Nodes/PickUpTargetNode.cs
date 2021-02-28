/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Pick Up Target")]
    public class PickUpTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Pick Up Target";

        public override System.Type Type => typeof(Thor.PickUpTarget);

        [GraphProcessor.Input("Picker")]
        public Thor.SharedEntity m_picker;

        [GraphProcessor.Input("Purchase"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_purchase;

        [GraphProcessor.Input("Slot"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_slot;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
