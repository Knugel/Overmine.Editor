/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare List Count")]
    public class CompareListCountNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare List Count";

        public override System.Type Type => typeof(Thor.CompareListCount);

        [GraphProcessor.Input("List")]
        public Thor.SharedEntityList m_list;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.Unity.Math.IntComparison.Operation m_operation;

        [GraphProcessor.Input("Count"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_count;

    }
}
