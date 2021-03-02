/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Entity Data")]
    public class GetEntityDataNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Entity Data";

        public override System.Type Type => typeof(Thor.GetEntityData);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data Output")]
        public Thor.SharedDataObject m_dataOutput;

    }
}
