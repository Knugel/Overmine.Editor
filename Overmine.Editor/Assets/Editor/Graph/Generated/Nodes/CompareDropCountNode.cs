/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Drop Count")]
    public class CompareDropCountNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Drop Count";

        public override System.Type Type => typeof(Thor.CompareDropCount);

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.Unity.Math.IntComparison.Operation m_operation;

        [GraphProcessor.Input("Count"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_count;

    }
}
