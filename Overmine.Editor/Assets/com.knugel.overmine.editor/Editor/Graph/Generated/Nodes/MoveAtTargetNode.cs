/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Move At Target")]
    public class MoveAtTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Move At Target";

        public override System.Type Type => typeof(Thor.MoveAtTarget);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Target Position"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_targetPosition;

        [GraphProcessor.Input("Run Until Reached"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_runUntilReached;

    }
}
