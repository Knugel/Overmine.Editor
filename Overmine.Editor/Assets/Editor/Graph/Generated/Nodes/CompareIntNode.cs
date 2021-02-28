/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Int")]
    public class CompareIntNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Int";

        public override System.Type Type => typeof(Thor.CompareInt);

        [GraphProcessor.Input("Int"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_int;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.Unity.Math.IntComparison.Operation m_operation;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_value;

    }
}
