/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fade To Black")]
    public class FadeToBlackNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fade To Black";

        public override System.Type Type => typeof(Thor.FadeToBlack);

        [GraphProcessor.Input("State"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_state;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

    }
}
