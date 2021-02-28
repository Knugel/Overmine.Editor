/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Entity")]
    public class CompareEntityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Entity";

        public override System.Type Type => typeof(Thor.CompareEntity);

        [GraphProcessor.Input("Rhs")]
        public Thor.SharedEntity m_rhs;

        [GraphProcessor.Input("Lhs")]
        public Thor.SharedEntity m_lhs;

    }
}
