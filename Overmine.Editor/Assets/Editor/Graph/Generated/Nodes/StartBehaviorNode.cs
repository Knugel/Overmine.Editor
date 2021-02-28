/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Start Behavior")]
    public class StartBehaviorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Start Behavior";

        public override System.Type Type => typeof(Thor.StartBehavior);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public System.String m_name;

    }
}
