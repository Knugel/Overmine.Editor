/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Clear Entity List")]
    public class ClearEntityListNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Clear Entity List";

        public override System.Type Type => typeof(Thor.ClearEntityList);

        [GraphProcessor.Input("Entity List")]
        public Thor.SharedEntityList m_entityList;

    }
}
