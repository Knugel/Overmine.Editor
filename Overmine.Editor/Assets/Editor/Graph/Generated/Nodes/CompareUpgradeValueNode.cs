/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Upgrade Value")]
    public class CompareUpgradeValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Upgrade Value";

        public override System.Type Type => typeof(Thor.CompareUpgradeValue);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.Unity.Math.IntComparison.Operation m_operation;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_value;

    }
}
