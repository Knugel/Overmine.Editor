/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Stat Max")]
    public class SetStatMaxNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Stat Max";

        public override System.Type Type => typeof(Thor.SetStatMax);

        [GraphProcessor.Input("Stat")]
        public Thor.StatData m_stat;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_value;

    }
}
