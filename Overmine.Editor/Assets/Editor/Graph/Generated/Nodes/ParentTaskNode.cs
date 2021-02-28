/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Parent Task")]
    public class ParentTaskNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Parent Task";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.ParentTask);

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Owner")]
        public BehaviorDesigner.Runtime.Behavior owner;

        [GraphProcessor.ShowInInspector]
        public System.Int32 id;

        [GraphProcessor.ShowInInspector]
        public System.String friendlyName;

        [GraphProcessor.ShowInInspector]
        public System.Boolean instant;

    }
}
