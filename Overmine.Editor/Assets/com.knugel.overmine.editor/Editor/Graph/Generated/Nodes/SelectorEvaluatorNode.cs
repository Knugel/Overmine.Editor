/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Selector Evaluator")]
    public class SelectorEvaluatorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Selector Evaluator";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.SelectorEvaluator);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.AbortType abortType;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
