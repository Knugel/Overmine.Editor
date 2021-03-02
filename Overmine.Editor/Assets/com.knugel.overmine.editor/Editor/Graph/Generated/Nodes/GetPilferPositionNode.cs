/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Pilfer Position")]
    public class GetPilferPositionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Pilfer Position";

        public override System.Type Type => typeof(Thor.GetPilferPosition);

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

        [GraphProcessor.Input("Min Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_minDistance;

    }
}
