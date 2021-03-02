/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Random Room Position")]
    public class GetRandomRoomPositionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Random Room Position";

        public override System.Type Type => typeof(Thor.GetRandomRoomPosition);

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

        [GraphProcessor.Input("Grid Aligned"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_gridAligned;

        [GraphProcessor.Input("Walkable"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_walkable;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
