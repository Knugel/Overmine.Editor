/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Disperse")]
    public class DisperseNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Disperse";

        public override System.Type Type => typeof(Thor.Disperse);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
