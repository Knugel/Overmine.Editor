/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Pause For")]
    public class PauseForNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Pause For";

        public override System.Type Type => typeof(Thor.PauseFor);

        [GraphProcessor.Input("Seconds"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_seconds;

    }
}
