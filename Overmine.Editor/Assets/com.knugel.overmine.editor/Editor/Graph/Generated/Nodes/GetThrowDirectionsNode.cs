/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Throw Directions")]
    public class GetThrowDirectionsNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Throw Directions";

        public override System.Type Type => typeof(Thor.GetThrowDirections);

        [GraphProcessor.Input("Output")]
        public Thor.SharedVector3List m_output;

        [GraphProcessor.Input("Count"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_count;

    }
}
