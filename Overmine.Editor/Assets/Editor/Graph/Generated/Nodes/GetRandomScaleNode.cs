/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Random Scale")]
    public class GetRandomScaleNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Random Scale";

        public override System.Type Type => typeof(Thor.GetRandomScale);

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

    }
}
