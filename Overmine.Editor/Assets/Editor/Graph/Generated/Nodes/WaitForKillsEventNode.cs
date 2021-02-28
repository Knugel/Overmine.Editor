/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Kills Event")]
    public class WaitForKillsEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Kills Event";

        public override System.Type Type => typeof(Thor.WaitForKillsEvent);

        [GraphProcessor.Input("Killee Output")]
        public Thor.SharedEntity m_killeeOutput;

        [GraphProcessor.Input("Position Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_positionOutput;

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
