/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Reveal Map")]
    public class RevealMapNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Reveal Map";

        public override System.Type Type => typeof(Thor.RevealMap);

        [GraphProcessor.Input("Reveal"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_reveal;

    }
}
