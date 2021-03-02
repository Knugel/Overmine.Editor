/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Shake Camera")]
    public class ShakeCameraNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Shake Camera";

        public override System.Type Type => typeof(Thor.ShakeCamera);

        [GraphProcessor.ShowInInspector]
        public Thor.ShakeCamera.Strength m_strength;

    }
}
