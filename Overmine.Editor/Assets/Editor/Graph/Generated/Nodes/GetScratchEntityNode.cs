/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Scratch Entity")]
    public class GetScratchEntityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Scratch Entity";

        public override System.Type Type => typeof(Thor.GetScratchEntity);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Key"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_key;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
