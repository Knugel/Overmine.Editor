/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Animation Data")]
    public class SetAnimationDataNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Animation Data";

        public override System.Type Type => typeof(Thor.SetAnimationData);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        public Thor.FullAnimationData m_data;

    }
}
