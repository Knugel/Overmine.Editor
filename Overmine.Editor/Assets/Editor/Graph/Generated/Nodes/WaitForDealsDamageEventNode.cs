/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Deals Damage Event")]
    public class WaitForDealsDamageEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Deals Damage Event";

        public override System.Type Type => typeof(Thor.WaitForDealsDamageEvent);

        [GraphProcessor.Input("Victim Output")]
        public Thor.SharedEntity m_victimOutput;

        [GraphProcessor.Input("Amount Output")]
        public BehaviorDesigner.Runtime.SharedInt m_amountOutput;

        [GraphProcessor.Input("Type Output")]
        public BehaviorDesigner.Runtime.SharedInt m_typeOutput;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Input("Timeout"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_timeout;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
