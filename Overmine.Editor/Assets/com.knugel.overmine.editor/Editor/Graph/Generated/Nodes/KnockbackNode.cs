/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Knockback")]
    public class KnockbackNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Knockback";

        public override System.Type Type => typeof(Thor.Knockback);

        [GraphProcessor.Input("Knockee")]
        public Thor.SharedEntity m_knockee;

        [GraphProcessor.Input("Knocker")]
        public Thor.SharedEntity m_knocker;

        [GraphProcessor.Input("Direction"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_direction;

        [GraphProcessor.Input("Multiplier"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_multiplier;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

        [GraphProcessor.Input("Min Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector2 m_minAngle;

        [GraphProcessor.Input("Max Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector2 m_maxAngle;

        [GraphProcessor.Input("Walkable"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_walkable;

    }
}
