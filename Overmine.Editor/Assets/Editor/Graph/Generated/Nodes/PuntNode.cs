/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Punt")]
    public class PuntNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Punt";

        public override System.Type Type => typeof(Thor.Punt);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
