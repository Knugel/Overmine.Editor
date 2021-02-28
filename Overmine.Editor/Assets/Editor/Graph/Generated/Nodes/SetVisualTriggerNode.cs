/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Visual Trigger")]
    public class SetVisualTriggerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Visual Trigger";

        public override System.Type Type => typeof(Thor.SetVisualTrigger);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("State"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_state;

    }
}
