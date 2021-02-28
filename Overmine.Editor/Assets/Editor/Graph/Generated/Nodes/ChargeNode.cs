/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Charge")]
    public class ChargeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Charge";

        public override System.Type Type => typeof(Thor.Charge);

        [GraphProcessor.Input("Chargee")]
        public Thor.SharedEntity m_chargee;

        [GraphProcessor.Input("Charger")]
        public Thor.SharedEntity m_charger;

        [GraphProcessor.Input("Allow Partial"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_allowPartial;

    }
}
