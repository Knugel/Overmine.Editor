/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Altar Item")]
    public class SetAltarItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Altar Item";

        public override System.Type Type => typeof(Thor.SetAltarItem);

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
