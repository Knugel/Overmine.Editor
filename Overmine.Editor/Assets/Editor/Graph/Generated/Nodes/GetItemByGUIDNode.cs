/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Item By GUID")]
    public class GetItemByGUIDNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Item By GUID";

        public override System.Type Type => typeof(Thor.GetItemByGUID);

        [GraphProcessor.Input("Guid"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_guid;

        [GraphProcessor.Input("Data Output")]
        public Thor.SharedDataObject m_dataOutput;

    }
}
