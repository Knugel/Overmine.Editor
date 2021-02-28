/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Increment Drop Count")]
    public class IncrementDropCountNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Increment Drop Count";

        public override System.Type Type => typeof(Thor.IncrementDropCount);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
