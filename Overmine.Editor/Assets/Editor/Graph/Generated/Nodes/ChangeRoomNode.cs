/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Change Room")]
    public class ChangeRoomNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Change Room";

        public override System.Type Type => typeof(Thor.ChangeRoom);

        [GraphProcessor.ShowInInspector]
        public Thor.Direction m_direction;

        [GraphProcessor.ShowInInspector]
        public Thor.Zone.RoomMoveType m_moveType;

    }
}
