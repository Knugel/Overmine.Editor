/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Stat")]
    public class SetStatNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Stat";

        public override System.Type Type => typeof(Thor.SetStat);

        [GraphProcessor.Input("Stat")]
        public Thor.StatData m_stat;

        [GraphProcessor.Input("Operator"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_operator;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_value;

    }
}
