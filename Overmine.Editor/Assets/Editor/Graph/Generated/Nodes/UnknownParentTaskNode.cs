/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unknown Parent Task")]
    public class UnknownParentTaskNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unknown Parent Task";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.UnknownParentTask);

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
