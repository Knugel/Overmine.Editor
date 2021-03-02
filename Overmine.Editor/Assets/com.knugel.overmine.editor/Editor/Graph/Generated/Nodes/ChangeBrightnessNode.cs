/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Change Brightness")]
    public class ChangeBrightnessNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Change Brightness";

        public override System.Type Type => typeof(Thor.ChangeBrightness);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_amount;

    }
}
