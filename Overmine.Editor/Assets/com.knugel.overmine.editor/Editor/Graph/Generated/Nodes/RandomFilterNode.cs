/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Random Filter")]
    public class RandomFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Random Filter";

        public override System.Type Type => typeof(Thor.RandomFilter);

        [GraphProcessor.Input("Input")]
        public Thor.SharedEntityList m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
