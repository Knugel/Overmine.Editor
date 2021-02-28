/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Show Kicker")]
    public class ShowKickerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Show Kicker";

        public override System.Type Type => typeof(Thor.ShowKicker);

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Loc I D")]
        public Thor.LocID m_locID;

    }
}
