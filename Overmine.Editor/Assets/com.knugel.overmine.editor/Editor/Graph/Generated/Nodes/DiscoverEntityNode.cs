/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Discover Entity")]
    public class DiscoverEntityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Discover Entity";

        public override System.Type Type => typeof(Thor.DiscoverEntity);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
