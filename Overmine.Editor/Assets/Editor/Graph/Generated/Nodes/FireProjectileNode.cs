/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fire Projectile")]
    public class FireProjectileNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fire Projectile";

        public override System.Type Type => typeof(Thor.FireProjectile);

        [GraphProcessor.ShowInInspector]
        public Thor.ProjectileExt.ProjectileType m_type;

        [GraphProcessor.Input("Data")]
        public Thor.TargetData m_data;

        [GraphProcessor.Input("Projectile")]
        public Thor.SharedEntity m_projectile;

        [GraphProcessor.Input("Firer")]
        public Thor.SharedEntity m_firer;

        [GraphProcessor.Input("Projectile Owner")]
        public Thor.SharedEntity m_projectileOwner;

        [GraphProcessor.Input("Projectile Output")]
        public Thor.SharedEntity m_projectileOutput;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        [GraphProcessor.Input("Spread"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_spread;

        [GraphProcessor.Input("Max Spread"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_maxSpread;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

        [GraphProcessor.Input("Range"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_range;

        [GraphProcessor.Input("Size"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_size;

        [GraphProcessor.Input("Angle"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_angle;

        [GraphProcessor.Input("Direct"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_direct;

        [GraphProcessor.Input("Walkable"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_walkable;

    }
}
