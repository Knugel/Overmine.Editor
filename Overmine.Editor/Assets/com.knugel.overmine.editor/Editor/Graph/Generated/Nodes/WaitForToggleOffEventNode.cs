/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Toggle Off Event")]
    public class WaitForToggleOffEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Toggle Off Event";

        public override System.Type Type => typeof(Thor.WaitForToggleOffEvent);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Input("Timeout"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_timeout;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        /* The type Thor.WaitForToggleEvent.ToggleType is private and has been replaced by 'object'!*/
        [GraphProcessor.ShowInInspector]
        public object m_toggleType;

        [GraphProcessor.Input("State Output")]
        public BehaviorDesigner.Runtime.SharedBool m_stateOutput;

        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
