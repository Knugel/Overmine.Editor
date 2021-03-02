/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Conditional Evaluator")]
    public class ConditionalEvaluatorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Conditional Evaluator";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator);

        [GraphProcessor.Input("Reevaluate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool reevaluate;

        public BehaviorDesigner.Runtime.Tasks.Conditional conditionalTask;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
