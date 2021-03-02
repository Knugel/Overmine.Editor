/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Random Move Position")]
    public class GetRandomMovePositionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Random Move Position";

        public override System.Type Type => typeof(Thor.GetRandomMovePosition);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

        [GraphProcessor.Input("Min Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_minDistance;

        [GraphProcessor.Input("Max Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_maxDistance;

        [GraphProcessor.Input("Towards")]
        public Thor.SharedEntity m_towards;

        [GraphProcessor.Input("Angle Range"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_angleRange;

    }
}
