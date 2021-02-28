/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Int2 Float")]
    public class Int2FloatNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Int2 Float";

        public override System.Type Type => typeof(Thor.Int2Float);

        [GraphProcessor.Input("Input"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_input;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedFloat m_output;

    }
}
