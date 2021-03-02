/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Nearest Walkable Position")]
    public class GetNearestWalkablePositionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Nearest Walkable Position";

        public override System.Type Type => typeof(Thor.GetNearestWalkablePosition);

        [GraphProcessor.Input("Agent")]
        public Thor.SharedEntity m_agent;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

    }
}
