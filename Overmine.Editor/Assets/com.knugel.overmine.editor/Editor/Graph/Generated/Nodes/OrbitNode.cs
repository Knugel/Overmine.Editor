/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Orbit")]
    public class OrbitNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Orbit";

        public override System.Type Type => typeof(Thor.Orbit);

        [GraphProcessor.Input("Orbiter")]
        public Thor.SharedEntity m_orbiter;

        [GraphProcessor.Input("Orbit Target")]
        public Thor.SharedEntity m_orbitTarget;

    }
}
