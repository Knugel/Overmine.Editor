/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fill Hazard")]
    public class FillHazardNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fill Hazard";

        public override System.Type Type => typeof(Thor.FillHazard);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public Thor.HazardExt.HazardType m_type;

        [GraphProcessor.Input("Radius"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_radius;

        [GraphProcessor.Input("Size"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_size;

        [GraphProcessor.Input("Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_duration;

    }
}
