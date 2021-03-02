/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Item Combo")]
    public class HasItemComboNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Item Combo";

        public override System.Type Type => typeof(Thor.HasItemCombo);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
