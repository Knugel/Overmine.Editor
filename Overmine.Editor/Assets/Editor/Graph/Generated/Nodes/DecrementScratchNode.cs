/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Decrement Scratch")]
    public class DecrementScratchNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Decrement Scratch";

        public override System.Type Type => typeof(Thor.DecrementScratch);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Scratch"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_scratch;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
