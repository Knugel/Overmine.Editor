/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Check Projectile Bubble")]
    public class CheckProjectileBubbleNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Check Projectile Bubble";

        public override System.Type Type => typeof(Thor.CheckProjectileBubble);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Projectile")]
        public Thor.SharedEntity m_projectile;

        public UnityEngine.LayerMask m_layerMask;

    }
}
