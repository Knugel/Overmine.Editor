/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Carry")]
    public class CarryNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Carry";

        public override System.Type Type => typeof(Thor.Carry);

        [GraphProcessor.Input("Carrier")]
        public Thor.SharedEntity m_carrier;

        [GraphProcessor.Input("Carryable")]
        public Thor.SharedEntity m_carryable;

    }
}
