/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Status Filter")]
    public class StatusFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Status Filter";

        public override System.Type Type => typeof(Thor.StatusFilter);

        [GraphProcessor.Input("Status Effect")]
        public Thor.SharedEntity m_statusEffect;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_negate;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
