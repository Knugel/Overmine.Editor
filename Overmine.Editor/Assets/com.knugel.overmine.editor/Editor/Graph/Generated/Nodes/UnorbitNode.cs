/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unorbit")]
    public class UnorbitNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unorbit";

        public override System.Type Type => typeof(Thor.Unorbit);

        [GraphProcessor.Input("Orbiter")]
        public Thor.SharedEntity m_orbiter;

    }
}
