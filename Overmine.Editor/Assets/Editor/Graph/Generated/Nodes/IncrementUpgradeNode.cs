/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Increment Upgrade")]
    public class IncrementUpgradeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Increment Upgrade";

        public override System.Type Type => typeof(Thor.IncrementUpgrade);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
