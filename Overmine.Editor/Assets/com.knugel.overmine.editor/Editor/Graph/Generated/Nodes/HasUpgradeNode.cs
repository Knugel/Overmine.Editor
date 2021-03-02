/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Upgrade")]
    public class HasUpgradeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Upgrade";

        public override System.Type Type => typeof(Thor.HasUpgrade);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.Input("Invert"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_invert;

    }
}
