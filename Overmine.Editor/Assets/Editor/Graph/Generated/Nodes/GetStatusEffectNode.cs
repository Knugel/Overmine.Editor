/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Status Effect")]
    public class GetStatusEffectNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Status Effect";

        public override System.Type Type => typeof(Thor.GetStatusEffect);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

    }
}
