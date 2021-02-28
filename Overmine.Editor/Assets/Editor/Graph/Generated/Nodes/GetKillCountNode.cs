/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Kill Count")]
    public class GetKillCountNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Kill Count";

        public override System.Type Type => typeof(Thor.GetKillCount);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.EntityData m_data;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedInt m_output;

    }
}
