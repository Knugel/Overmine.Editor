/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Item Count")]
    public class GetItemCountNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Item Count";

        public override System.Type Type => typeof(Thor.GetItemCount);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.ItemData.ItemHint m_hint;

        [GraphProcessor.Input("Count Output")]
        public BehaviorDesigner.Runtime.SharedInt m_countOutput;

    }
}
