/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Lock Item")]
    public class LockItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Lock Item";

        public override System.Type Type => typeof(Thor.LockItem);

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
