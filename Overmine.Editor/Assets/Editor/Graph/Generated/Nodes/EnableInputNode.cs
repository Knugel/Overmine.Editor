/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Enable Input")]
    public class EnableInputNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Enable Input";

        public override System.Type Type => typeof(Thor.EnableInput);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
