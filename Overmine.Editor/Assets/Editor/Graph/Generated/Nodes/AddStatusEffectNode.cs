/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Status Effect")]
    public class AddStatusEffectNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Status Effect";

        public override System.Type Type => typeof(Thor.AddStatusEffect);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Status Effect")]
        public Thor.SharedEntity m_statusEffect;

        [GraphProcessor.Input("Data")]
        public Thor.StatusEffectExt.StatusEffectData m_data;

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

    }
}
