/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Inverter")]
    public class InverterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Inverter";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.Inverter);

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
