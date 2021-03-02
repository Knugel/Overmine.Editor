/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Distort Camera")]
    public class DistortCameraNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Distort Camera";

        public override System.Type Type => typeof(Thor.DistortCamera);

        [GraphProcessor.Input("Distortion"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_distortion;

    }
}
