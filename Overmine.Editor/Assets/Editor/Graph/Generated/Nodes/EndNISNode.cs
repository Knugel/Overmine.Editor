/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("End NIS")]
    public class EndNISNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "End NIS";

        public override System.Type Type => typeof(Thor.EndNIS);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
