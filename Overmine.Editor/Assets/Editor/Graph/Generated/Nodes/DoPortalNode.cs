/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Do Portal")]
    public class DoPortalNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Do Portal";

        public override System.Type Type => typeof(Thor.DoPortal);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
