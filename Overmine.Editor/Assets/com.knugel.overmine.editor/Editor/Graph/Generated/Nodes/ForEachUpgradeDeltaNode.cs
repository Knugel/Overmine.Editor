/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("For Each Upgrade Delta")]
    public class ForEachUpgradeDeltaNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "For Each Upgrade Delta";

        public override System.Type Type => typeof(Thor.ForEachUpgradeDelta);

        [GraphProcessor.Input("Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_upgrade;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
