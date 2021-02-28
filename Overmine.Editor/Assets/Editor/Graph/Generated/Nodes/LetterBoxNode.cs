/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Letter Box")]
    public class LetterBoxNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Letter Box";

        public override System.Type Type => typeof(Thor.LetterBox);

        [GraphProcessor.Input("State"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_state;

        [GraphProcessor.Input("Speed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_speed;

    }
}
