/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove From Entity List")]
    public class RemoveFromEntityListNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove From Entity List";

        public override System.Type Type => typeof(Thor.RemoveFromEntityList);

        [GraphProcessor.Input("Entity List")]
        public Thor.SharedEntityList m_entityList;

        [GraphProcessor.Input("Entity")]
        public Thor.SharedEntity m_entity;

    }
}
