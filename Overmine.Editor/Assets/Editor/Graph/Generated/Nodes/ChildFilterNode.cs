/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Child Filter")]
    public class ChildFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Child Filter";

        public override System.Type Type => typeof(Thor.ChildFilter);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
