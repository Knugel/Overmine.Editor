/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("On H P Threshold")]
    public class OnHPThresholdNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "On H P Threshold";

        public override System.Type Type => typeof(Thor.OnHPThreshold);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Input("Every Percent"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_everyPercent;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
