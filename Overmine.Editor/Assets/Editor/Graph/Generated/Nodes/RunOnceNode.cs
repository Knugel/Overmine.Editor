/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Run Once")]
    public class RunOnceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Run Once";

        public override System.Type Type => typeof(Thor.RunOnce);

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
