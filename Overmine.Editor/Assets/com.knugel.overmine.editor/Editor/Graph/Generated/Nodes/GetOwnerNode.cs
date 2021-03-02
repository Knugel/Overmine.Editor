/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Owner")]
    public class GetOwnerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Owner";

        public override System.Type Type => typeof(Thor.GetOwner);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
