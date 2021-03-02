/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Item Type")]
    public class CompareItemTypeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Item Type";

        public override System.Type Type => typeof(Thor.CompareItemType);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.ItemData.ItemHint m_hint;

    }
}
