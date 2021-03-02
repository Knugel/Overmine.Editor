/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Probe Hazard")]
    public class ProbeHazardNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Probe Hazard";

        public override System.Type Type => typeof(Thor.ProbeHazard);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        [GraphProcessor.ShowInInspector]
        public Thor.HazardExt.HazardType m_type;

    }
}
