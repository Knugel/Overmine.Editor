/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Visual Value")]
    public class SetVisualValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Visual Value";

        public override System.Type Type => typeof(Thor.SetVisualValue);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("State"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_state;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_value;

    }
}
