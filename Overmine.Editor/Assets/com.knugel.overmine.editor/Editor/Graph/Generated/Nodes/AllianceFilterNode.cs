/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Alliance Filter")]
    public class AllianceFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Alliance Filter";

        public override System.Type Type => typeof(Thor.AllianceFilter);

        [GraphProcessor.Input("Compare With")]
        public Thor.SharedEntity m_compareWith;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<Thor.AllianceManager.Alliance> m_alliances;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
