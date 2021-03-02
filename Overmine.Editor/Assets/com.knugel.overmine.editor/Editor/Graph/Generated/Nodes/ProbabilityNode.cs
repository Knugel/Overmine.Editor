/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Probability")]
    public class ProbabilityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Probability";

        public override System.Type Type => typeof(Thor.Probability);

        [GraphProcessor.Input("Probability"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_probability;

    }
}
