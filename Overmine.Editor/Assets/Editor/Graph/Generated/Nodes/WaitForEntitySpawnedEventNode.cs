/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Entity Spawned Event")]
    public class WaitForEntitySpawnedEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Entity Spawned Event";

        public override System.Type Type => typeof(Thor.WaitForEntitySpawnedEvent);

        [GraphProcessor.Input("Entity Output")]
        public Thor.SharedEntity m_entityOutput;

        [GraphProcessor.Input("Position Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_positionOutput;

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_tag;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
