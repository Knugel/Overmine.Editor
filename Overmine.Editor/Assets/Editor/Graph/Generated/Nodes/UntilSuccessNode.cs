/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Until Success")]
    public class UntilSuccessNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Until Success";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.UntilSuccess);

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
