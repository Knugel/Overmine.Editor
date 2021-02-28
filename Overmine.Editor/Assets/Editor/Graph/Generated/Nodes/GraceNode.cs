/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Grace")]
    public class GraceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Grace";

        public override System.Type Type => typeof(Thor.Grace);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
