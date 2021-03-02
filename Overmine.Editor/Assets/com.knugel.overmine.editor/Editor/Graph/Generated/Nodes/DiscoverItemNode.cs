/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Discover Item")]
    public class DiscoverItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Discover Item";

        public override System.Type Type => typeof(Thor.DiscoverItem);

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
