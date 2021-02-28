/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Direction")]
    public class GetDirectionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Direction";

        public override System.Type Type => typeof(Thor.GetDirection);

        [GraphProcessor.Input("From")]
        public Thor.SharedEntity m_from;

        [GraphProcessor.Input("To")]
        public Thor.SharedEntity m_to;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

    }
}
