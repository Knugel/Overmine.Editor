/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Status Effects")]
    public class GetStatusEffectsNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Status Effects";

        public override System.Type Type => typeof(Thor.GetStatusEffects);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
