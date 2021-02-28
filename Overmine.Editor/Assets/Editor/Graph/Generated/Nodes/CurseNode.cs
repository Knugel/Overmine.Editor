/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Curse")]
    public class CurseNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Curse";

        public override System.Type Type => typeof(Thor.Curse);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.ShowInInspector]
        public Thor.HealthExt.CurseType m_type;

    }
}
