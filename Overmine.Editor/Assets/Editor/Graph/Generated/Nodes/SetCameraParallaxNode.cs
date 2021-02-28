/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Camera Parallax")]
    public class SetCameraParallaxNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Camera Parallax";

        public override System.Type Type => typeof(Thor.SetCameraParallax);

        [GraphProcessor.Input("Parallax"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_parallax;

    }
}
