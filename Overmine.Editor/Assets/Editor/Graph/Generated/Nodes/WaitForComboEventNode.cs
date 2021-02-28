/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Combo Event")]
    public class WaitForComboEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Combo Event";

        public override System.Type Type => typeof(Thor.WaitForComboEvent);

        [GraphProcessor.Input("Comboer Output")]
        public Thor.SharedEntity m_comboerOutput;

        [GraphProcessor.Input("Count Output")]
        public BehaviorDesigner.Runtime.SharedInt m_countOutput;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Input("Timeout"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_timeout;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
