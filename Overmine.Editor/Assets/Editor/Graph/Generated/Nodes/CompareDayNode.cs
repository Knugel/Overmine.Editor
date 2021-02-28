/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Day")]
    public class CompareDayNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Day";

        public override System.Type Type => typeof(Thor.CompareDay);

        [GraphProcessor.Input("Month"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_month;

        [GraphProcessor.Input("Day"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_day;

        [GraphProcessor.Input("Invert"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_invert;

    }
}
