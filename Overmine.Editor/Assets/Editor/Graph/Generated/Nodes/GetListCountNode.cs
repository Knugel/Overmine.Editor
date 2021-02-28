/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get List Count")]
    public class GetListCountNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get List Count";

        public override System.Type Type => typeof(Thor.GetListCount);

        [GraphProcessor.Input("List")]
        public Thor.SharedEntityList m_list;

        [GraphProcessor.Input("Count Output")]
        public BehaviorDesigner.Runtime.SharedInt m_countOutput;

    }
}
