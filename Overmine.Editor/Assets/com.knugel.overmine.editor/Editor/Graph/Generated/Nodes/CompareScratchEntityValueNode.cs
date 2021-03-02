/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Scratch Entity Value")]
    public class CompareScratchEntityValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Scratch Entity Value";

        public override System.Type Type => typeof(Thor.CompareScratchEntityValue);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Scratch"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_scratch;

        [GraphProcessor.Input("Value")]
        public Thor.SharedEntity m_value;

    }
}
