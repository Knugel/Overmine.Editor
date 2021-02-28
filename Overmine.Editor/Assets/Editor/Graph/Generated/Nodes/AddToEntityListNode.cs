/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add To Entity List")]
    public class AddToEntityListNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add To Entity List";

        public override System.Type Type => typeof(Thor.AddToEntityList);

        [GraphProcessor.Input("Entity")]
        public Thor.SharedEntity m_entity;

        [GraphProcessor.Input("Entity List")]
        public Thor.SharedEntityList m_entityList;

    }
}
