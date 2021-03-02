/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Extra")]
    public class AddExtraNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Extra";

        public override System.Type Type => typeof(Thor.AddExtra);

        [GraphProcessor.Input("Extra")]
        public Thor.Spawner.SpawnTable m_extra;

    }
}
