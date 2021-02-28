/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Item Data")]
    public class SetItemDataNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Item Data";

        public override System.Type Type => typeof(Thor.SetItemData);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
