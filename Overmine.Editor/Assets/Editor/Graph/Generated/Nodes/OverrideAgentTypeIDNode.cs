/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Override Agent Type I D")]
    public class OverrideAgentTypeIDNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Override Agent Type I D";

        public override System.Type Type => typeof(Thor.OverrideAgentTypeID);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.OverrideAgentTypeID.AgentType m_type;

    }
}
