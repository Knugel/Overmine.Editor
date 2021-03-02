/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("New Filter")]
    public class NewFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "New Filter";

        public override System.Type Type => typeof(Thor.NewFilter);

        [GraphProcessor.Input("Clear On Complete"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_clearOnComplete;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
