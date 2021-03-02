/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Shove")]
    public class ShoveNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Shove";

        public override System.Type Type => typeof(Thor.Shove);

        [GraphProcessor.Input("Shovee")]
        public Thor.SharedEntity m_shovee;

        [GraphProcessor.Input("Shover")]
        public Thor.SharedEntity m_shover;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

        [GraphProcessor.Input("Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_duration;

        [GraphProcessor.Input("Min Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector2 m_minAngle;

        [GraphProcessor.Input("Max Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector2 m_maxAngle;

    }
}
