/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Credit")]
    public class CreditNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Credit";

        public override System.Type Type => typeof(Thor.Credit);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.ShowInInspector]
        public Thor.CostExt.CostType m_costType;

        [GraphProcessor.Input("Cost Modifier Key"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_costModifierKey;

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

    }
}
