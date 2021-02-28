/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Random Direction")]
    public class GetRandomDirectionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Random Direction";

        public override System.Type Type => typeof(Thor.GetRandomDirection);

        [GraphProcessor.Input("Minimum"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_minimum;

        [GraphProcessor.Input("Maximum"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_maximum;

        [GraphProcessor.Input("Normalize"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_normalize;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

    }
}
