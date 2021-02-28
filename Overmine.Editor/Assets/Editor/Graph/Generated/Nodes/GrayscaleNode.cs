/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Grayscale")]
    public class GrayscaleNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Grayscale";

        public override System.Type Type => typeof(Thor.Grayscale);

        [GraphProcessor.Input("Enabled"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_enabled;

    }
}
