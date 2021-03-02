/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Decrement Upgrade")]
    public class DecrementUpgradeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Decrement Upgrade";

        public override System.Type Type => typeof(Thor.DecrementUpgrade);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
