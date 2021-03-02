/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Choose Item")]
    public class ChooseItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Choose Item";

        public override System.Type Type => typeof(Thor.ChooseItem);

        [GraphProcessor.Input("Avatar")]
        public Thor.SharedEntity m_avatar;

        [GraphProcessor.Input("Data")]
        public Thor.ChooseItem.ChooseItemData m_data;

        [GraphProcessor.Input("Item Oputput")]
        public Thor.SharedDataObject m_itemOputput;

    }
}
