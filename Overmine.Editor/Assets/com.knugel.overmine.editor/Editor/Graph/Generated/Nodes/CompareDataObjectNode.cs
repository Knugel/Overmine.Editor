/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Data Object")]
    public class CompareDataObjectNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Data Object";

        public override System.Type Type => typeof(Thor.CompareDataObject);

        [GraphProcessor.Input("Lhs")]
        public Thor.SharedDataObject m_lhs;

        [GraphProcessor.Input("Rhs")]
        public Thor.SharedDataObject m_rhs;

    }
}
