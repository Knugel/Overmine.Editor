/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Increment Scratch")]
    public class IncrementScratchNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Increment Scratch";

        public override System.Type Type => typeof(Thor.IncrementScratch);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Scratch"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_scratch;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
