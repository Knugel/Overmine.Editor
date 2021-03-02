/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Kill")]
    public class KillNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Kill";

        public override System.Type Type => typeof(Thor.Kill);

        [GraphProcessor.Input("Killee")]
        public Thor.SharedEntity m_killee;

        [GraphProcessor.Input("Killer")]
        public Thor.SharedEntity m_killer;

        [GraphProcessor.Input("Origin")]
        public Thor.SharedEntity m_origin;

    }
}
