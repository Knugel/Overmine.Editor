/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Scratch Value")]
    public class SetScratchValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Scratch Value";

        public override System.Type Type => typeof(Thor.SetScratchValue);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Key"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_key;

        [GraphProcessor.Input("Operator"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_operator;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_value;

    }
}
