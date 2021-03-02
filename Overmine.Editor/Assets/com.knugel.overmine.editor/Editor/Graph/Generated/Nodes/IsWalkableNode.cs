/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Is Walkable")]
    public class IsWalkableNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Is Walkable";

        public override System.Type Type => typeof(Thor.IsWalkable);

        [GraphProcessor.Input("Walker")]
        public Thor.SharedEntity m_walker;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

    }
}
