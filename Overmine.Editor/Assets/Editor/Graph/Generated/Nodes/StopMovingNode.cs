/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Stop Moving")]
    public class StopMovingNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Stop Moving";

        public override System.Type Type => typeof(Thor.StopMoving);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
