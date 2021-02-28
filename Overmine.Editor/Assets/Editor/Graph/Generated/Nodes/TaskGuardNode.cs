/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Task Guard")]
    public class TaskGuardNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Task Guard";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.TaskGuard);

        [GraphProcessor.Input("Max Task Access Count"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt maxTaskAccessCount;

        [GraphProcessor.Input("Linked Task Guards")]
        public BehaviorDesigner.Runtime.Tasks.TaskGuard[] linkedTaskGuards;

        [GraphProcessor.Input("Wait Until Task Available"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool waitUntilTaskAvailable;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
