/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Upgrade Delta")]
    public class GetUpgradeDeltaNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Upgrade Delta";

        public override System.Type Type => typeof(Thor.GetUpgradeDelta);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.Input("Delta"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_delta;

    }
}
