/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Gains Modifier Event")]
    public class WaitForGainsModifierEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Gains Modifier Event";

        public override System.Type Type => typeof(Thor.WaitForGainsModifierEvent);

        [GraphProcessor.Input("Type Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_typeName;

        [GraphProcessor.Input("Member Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_memberName;

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
