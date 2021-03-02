/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Return Projectile")]
    public class ReturnProjectileNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Return Projectile";

        public override System.Type Type => typeof(Thor.ReturnProjectile);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
