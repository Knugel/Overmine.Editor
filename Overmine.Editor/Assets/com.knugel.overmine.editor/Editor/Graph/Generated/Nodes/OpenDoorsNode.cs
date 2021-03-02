/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Open Doors")]
    public class OpenDoorsNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Open Doors";

        public override System.Type Type => typeof(Thor.OpenDoors);

        [GraphProcessor.ShowInInspector]
        public Thor.Direction m_direction;

    }
}
