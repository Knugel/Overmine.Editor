/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Disable Item")]
    public class DisableItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Disable Item";

        public override System.Type Type => typeof(Thor.DisableItem);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
