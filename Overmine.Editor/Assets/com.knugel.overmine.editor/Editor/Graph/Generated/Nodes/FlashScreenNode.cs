/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Flash Screen")]
    public class FlashScreenNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Flash Screen";

        public override System.Type Type => typeof(Thor.FlashScreen);

        [GraphProcessor.Input("Color")]
        public BehaviorDesigner.Runtime.SharedColor m_color;

    }
}
