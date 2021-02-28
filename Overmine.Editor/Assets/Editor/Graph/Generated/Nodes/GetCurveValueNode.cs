/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Curve Value")]
    public class GetCurveValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Curve Value";

        public override System.Type Type => typeof(Thor.GetCurveValue);

        [GraphProcessor.Input("Curve")]
        public BehaviorDesigner.Runtime.SharedAnimationCurve m_curve;

        [GraphProcessor.Input("Time"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_time;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedFloat m_output;

        [GraphProcessor.Input("Multiplier"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_multiplier;

    }
}
