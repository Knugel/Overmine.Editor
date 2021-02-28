/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Custom Sim Event")]
    public class WaitForCustomSimEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Custom Sim Event";

        public override System.Type Type => typeof(Thor.WaitForCustomSimEvent);

        [GraphProcessor.Input("Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_name;

        [GraphProcessor.Input("Source Output")]
        public Thor.SharedEntity m_sourceOutput;

        [GraphProcessor.Input("Data Output")]
        public Thor.SharedEntity m_dataOutput;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
