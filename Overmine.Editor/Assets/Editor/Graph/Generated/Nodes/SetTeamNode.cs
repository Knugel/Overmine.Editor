/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Team")]
    public class SetTeamNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Team";

        public override System.Type Type => typeof(Thor.SetTeam);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.AllianceManager.Team m_team;

    }
}
