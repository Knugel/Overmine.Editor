/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Random Item Data")]
    public class GetRandomItemDataNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Random Item Data";

        public override System.Type Type => typeof(Thor.GetRandomItemData);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.ItemData.ItemHint m_hint;

        [GraphProcessor.Input("Output1")]
        public Thor.SharedDataObject m_output1;

        [GraphProcessor.Input("Output2")]
        public Thor.SharedDataObject m_output2;

    }
}
