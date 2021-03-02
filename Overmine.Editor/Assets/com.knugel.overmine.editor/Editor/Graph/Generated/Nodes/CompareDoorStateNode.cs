/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Door State")]
    public class CompareDoorStateNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Door State";

        public override System.Type Type => typeof(Thor.CompareDoorState);

        [GraphProcessor.ShowInInspector]
        public Thor.Room.DoorStateType m_state;

    }
}
