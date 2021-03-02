/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Start NIS")]
    public class StartNISNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Start NIS";

        public override System.Type Type => typeof(Thor.StartNIS);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Wait Until Safe"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_waitUntilSafe;

    }
}
