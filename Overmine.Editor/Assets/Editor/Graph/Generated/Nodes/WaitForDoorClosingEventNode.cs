/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Door Closing Event")]
    public class WaitForDoorClosingEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Door Closing Event";

        public override System.Type Type => typeof(Thor.WaitForDoorClosingEvent);

        [GraphProcessor.Input("Door Output")]
        public Thor.SharedEntity m_doorOutput;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
