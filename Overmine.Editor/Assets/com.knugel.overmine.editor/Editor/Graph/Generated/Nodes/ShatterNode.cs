/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Shatter")]
    public class ShatterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Shatter";

        public override System.Type Type => typeof(Thor.Shatter);

        [GraphProcessor.Input("Shatterer")]
        public Thor.SharedEntity m_shatterer;

    }
}
