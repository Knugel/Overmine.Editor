/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Respawn Avatar")]
    public class RespawnAvatarNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Respawn Avatar";

        public override System.Type Type => typeof(Thor.RespawnAvatar);

        [GraphProcessor.Input("Player")]
        public Thor.SharedEntity m_player;

    }
}
