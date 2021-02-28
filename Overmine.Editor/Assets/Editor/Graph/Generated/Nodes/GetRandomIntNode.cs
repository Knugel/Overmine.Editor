/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Random Int")]
    public class GetRandomIntNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Random Int";

        public override System.Type Type => typeof(Thor.GetRandomInt);

        [GraphProcessor.Input("Min"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_min;

        [GraphProcessor.Input("Max"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_max;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedInt m_output;

    }
}
