/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Altar Item")]
    public class GetAltarItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Altar Item";

        public override System.Type Type => typeof(Thor.GetAltarItem);

        [GraphProcessor.Input("Data Output")]
        public Thor.SharedDataObject m_dataOutput;

    }
}
