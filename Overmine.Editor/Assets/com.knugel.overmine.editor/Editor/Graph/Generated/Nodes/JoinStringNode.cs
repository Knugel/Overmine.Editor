/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Join String")]
    public class JoinStringNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Join String";

        public override System.Type Type => typeof(Thor.JoinString);

        [GraphProcessor.Input("Lhs"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_lhs;

        [GraphProcessor.Input("Rhs"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_rhs;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedString m_output;

    }
}
