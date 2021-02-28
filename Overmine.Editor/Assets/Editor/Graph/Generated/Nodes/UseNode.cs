/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Use")]
    public class UseNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Use";

        public override System.Type Type => typeof(Thor.Use);

        [GraphProcessor.Input("Usee")]
        public Thor.SharedEntity m_usee;

        [GraphProcessor.Input("User")]
        public Thor.SharedEntity m_user;

    }
}
