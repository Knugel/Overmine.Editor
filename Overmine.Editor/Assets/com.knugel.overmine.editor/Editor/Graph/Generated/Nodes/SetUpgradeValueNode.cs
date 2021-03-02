/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Upgrade Value")]
    public class SetUpgradeValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Upgrade Value";

        public override System.Type Type => typeof(Thor.SetUpgradeValue);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.Input("Operator"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_operator;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_value;

    }
}
