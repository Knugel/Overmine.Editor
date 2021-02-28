/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Float2 Int")]
    public class Float2IntNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Float2 Int";

        public override System.Type Type => typeof(Thor.Float2Int);

        [GraphProcessor.Input("Input"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_input;

        [GraphProcessor.ShowInInspector]
        public Thor.Float2Int.RoundDirection m_round;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedInt m_output;

        [GraphProcessor.Input("Negate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_negate;

    }
}
