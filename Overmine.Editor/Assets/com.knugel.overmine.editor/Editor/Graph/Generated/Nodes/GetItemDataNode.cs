/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Item Data")]
    public class GetItemDataNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Item Data";

        public override System.Type Type => typeof(Thor.GetItemData);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data Output")]
        public Thor.SharedDataObject m_dataOutput;

    }
}
