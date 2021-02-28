/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Clear Move Target")]
    public class ClearMoveTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Clear Move Target";

        public override System.Type Type => typeof(Thor.ClearMoveTarget);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
