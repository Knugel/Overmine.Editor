/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Scratch Entity")]
    public class SetScratchEntityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Scratch Entity";

        public override System.Type Type => typeof(Thor.SetScratchEntity);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Key"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_key;

        [GraphProcessor.Input("Value")]
        public Thor.SharedEntity m_value;

    }
}
