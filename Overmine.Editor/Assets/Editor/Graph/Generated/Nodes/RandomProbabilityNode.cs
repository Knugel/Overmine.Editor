/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Random Probability")]
    public class RandomProbabilityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Random Probability";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.RandomProbability);

        [GraphProcessor.Input("Success Probability"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat successProbability;

        [GraphProcessor.Input("Seed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt seed;

        [GraphProcessor.Input("Use Seed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool useSeed;

    }
}
