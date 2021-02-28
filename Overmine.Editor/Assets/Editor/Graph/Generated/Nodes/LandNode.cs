/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Land")]
    public class LandNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Land";

        public override System.Type Type => typeof(Thor.Land);

        [GraphProcessor.Input("Lander")]
        public Thor.SharedEntity m_lander;

    }
}
