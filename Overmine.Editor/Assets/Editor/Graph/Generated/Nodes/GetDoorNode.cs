/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Door")]
    public class GetDoorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Door";

        public override System.Type Type => typeof(Thor.GetDoor);

        [GraphProcessor.ShowInInspector]
        public Thor.Direction m_direction;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
