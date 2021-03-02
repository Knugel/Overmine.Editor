/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Camera Offset")]
    public class SetCameraOffsetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Camera Offset";

        public override System.Type Type => typeof(Thor.SetCameraOffset);

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

    }
}
