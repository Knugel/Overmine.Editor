/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Camera Look At")]
    public class CameraLookAtNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Camera Look At";

        public override System.Type Type => typeof(Thor.CameraLookAt);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_duration;

    }
}
