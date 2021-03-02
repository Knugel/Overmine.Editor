/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Entity Dies Event")]
    public class WaitForEntityDiesEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Entity Dies Event";

        public override System.Type Type => typeof(Thor.WaitForEntityDiesEvent);

        [GraphProcessor.Input("Entity Output")]
        public Thor.SharedEntity m_entityOutput;

        [GraphProcessor.Input("Origin Output")]
        public Thor.SharedEntity m_originOutput;

        [GraphProcessor.Input("Killer Output")]
        public Thor.SharedEntity m_killerOutput;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
