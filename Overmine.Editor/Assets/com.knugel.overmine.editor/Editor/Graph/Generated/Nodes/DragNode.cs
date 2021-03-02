/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Drag")]
    public class DragNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Drag";

        public override System.Type Type => typeof(Thor.Drag);

        [GraphProcessor.Input("Dragee")]
        public Thor.SharedEntity m_dragee;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Offet"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offet;

        [GraphProcessor.Input("Force"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_force;

    }
}
