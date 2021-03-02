/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Items")]
    public class GetItemsNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Items";

        public override System.Type Type => typeof(Thor.GetItems);

        [GraphProcessor.ShowInInspector]
        public Thor.ItemData.ItemHint m_hint;

        [GraphProcessor.Input("Output")]
        public Thor.SharedDataObjectList m_output;

    }
}
