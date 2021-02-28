/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Is Discovered")]
    public class IsDiscoveredNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Is Discovered";

        public override System.Type Type => typeof(Thor.IsDiscovered);

        [GraphProcessor.Input("Target")]
        public Thor.SharedDataObject m_target;

    }
}
