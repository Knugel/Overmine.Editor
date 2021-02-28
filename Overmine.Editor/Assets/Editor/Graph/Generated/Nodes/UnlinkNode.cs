/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unlink")]
    public class UnlinkNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unlink";

        public override System.Type Type => typeof(Thor.Unlink);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Unlinker")]
        public Thor.SharedEntity m_unlinker;

    }
}
