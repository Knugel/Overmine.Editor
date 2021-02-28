/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Picks Up Event")]
    public class WaitForPicksUpEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Picks Up Event";

        public override System.Type Type => typeof(Thor.WaitForPicksUpEvent);

        [GraphProcessor.Input("Pickee Output")]
        public Thor.SharedEntity m_pickeeOutput;

        [GraphProcessor.Input("Data Output")]
        public Thor.SharedDataObject m_dataOutput;

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_tag;

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
