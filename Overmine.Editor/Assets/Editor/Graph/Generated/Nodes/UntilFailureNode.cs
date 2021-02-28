/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Until Failure")]
    public class UntilFailureNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Until Failure";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.UntilFailure);

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
