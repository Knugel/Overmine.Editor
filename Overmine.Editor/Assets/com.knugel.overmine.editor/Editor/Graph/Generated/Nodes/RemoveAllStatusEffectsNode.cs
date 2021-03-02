/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove All Status Effects")]
    public class RemoveAllStatusEffectsNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove All Status Effects";

        public override System.Type Type => typeof(Thor.RemoveAllStatusEffects);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<Thor.StatusEffectExt> m_exclusions;

    }
}
