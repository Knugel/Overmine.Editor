/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Parallel Selector")]
    public class ParallelSelectorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Parallel Selector";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.ParallelSelector);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.AbortType abortType;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
