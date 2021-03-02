/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Distance")]
    public class DistanceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Distance";

        public override System.Type Type => typeof(Thor.Distance);

        [GraphProcessor.Input("Entity1")]
        public Thor.SharedEntity m_entity1;

        [GraphProcessor.Input("Entity2")]
        public Thor.SharedEntity m_entity2;

        [GraphProcessor.Input("Distance Output")]
        public BehaviorDesigner.Runtime.SharedFloat m_distanceOutput;

    }
}
