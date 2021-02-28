/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Run Async Behavior")]
    public class RunAsyncBehaviorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Run Async Behavior";

        public override System.Type Type => typeof(Thor.RunAsyncBehavior);

        [GraphProcessor.ShowInInspector]
        public Thor.ExtendedExternalBehaviorTree m_behavior;

        [GraphProcessor.Input("Self")]
        public Thor.SharedEntity m_self;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
