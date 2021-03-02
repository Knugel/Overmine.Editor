/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Day Range")]
    public class CompareDayRangeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Day Range";

        public override System.Type Type => typeof(Thor.CompareDayRange);

        [GraphProcessor.Input("Year"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_year;

        [GraphProcessor.Input("Month"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_month;

        [GraphProcessor.Input("Day"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_day;

        [GraphProcessor.Input("Days Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_daysDuration;

    }
}
