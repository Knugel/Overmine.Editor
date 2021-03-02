/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get GUID")]
    public class GetGUIDNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get GUID";

        public override System.Type Type => typeof(Thor.GetGUID);

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

        [GraphProcessor.Input("Guid Output")]
        public BehaviorDesigner.Runtime.SharedString m_guidOutput;

    }
}
