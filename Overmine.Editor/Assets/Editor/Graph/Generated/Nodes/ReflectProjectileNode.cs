/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Reflect Projectile")]
    public class ReflectProjectileNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Reflect Projectile";

        public override System.Type Type => typeof(Thor.ReflectProjectile);

        [GraphProcessor.Input("Reflectee")]
        public Thor.SharedEntity m_reflectee;

        [GraphProcessor.Input("Reflector")]
        public Thor.SharedEntity m_reflector;

    }
}
