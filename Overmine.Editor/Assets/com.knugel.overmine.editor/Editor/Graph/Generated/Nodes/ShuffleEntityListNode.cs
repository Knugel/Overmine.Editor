/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Shuffle Entity List")]
    public class ShuffleEntityListNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Shuffle Entity List";

        public override System.Type Type => typeof(Thor.ShuffleEntityList);

        [GraphProcessor.Input("Entity List")]
        public Thor.SharedEntityList m_entityList;

    }
}
