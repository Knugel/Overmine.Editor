/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Scratch Value")]
    public class GetScratchValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Scratch Value";

        public override System.Type Type => typeof(Thor.GetScratchValue);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Scratch"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_scratch;

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_value;

        [GraphProcessor.Input("Value Int"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_valueInt;

    }
}
