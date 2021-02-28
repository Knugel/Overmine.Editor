/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fire Beam")]
    public class FireBeamNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fire Beam";

        public override System.Type Type => typeof(Thor.FireBeam);

        [GraphProcessor.Input("Beam")]
        public Thor.SharedEntity m_beam;

        [GraphProcessor.Input("Firer")]
        public Thor.SharedEntity m_firer;

        [GraphProcessor.Input("Endpoint")]
        public Thor.SharedEntity m_endpoint;

        [GraphProcessor.Input("Owner")]
        public Thor.SharedEntity m_owner;

        [GraphProcessor.Input("Width"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_width;

        [GraphProcessor.Input("Beam Output")]
        public Thor.SharedEntity m_beamOutput;

    }
}
