/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Split String")]
    public class SplitStringNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Split String";

        public override System.Type Type => typeof(Thor.SplitString);

        [GraphProcessor.Input("Input"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_input;

        [GraphProcessor.Input("Output1")]
        public BehaviorDesigner.Runtime.SharedString m_output1;

        [GraphProcessor.Input("Output2")]
        public BehaviorDesigner.Runtime.SharedString m_output2;

    }
}
