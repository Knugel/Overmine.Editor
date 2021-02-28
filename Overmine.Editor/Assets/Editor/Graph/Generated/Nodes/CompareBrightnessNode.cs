/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Brightness")]
    public class CompareBrightnessNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Brightness";

        public override System.Type Type => typeof(Thor.CompareBrightness);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.Unity.Math.FloatComparison.Operation m_operation;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_value;

    }
}
