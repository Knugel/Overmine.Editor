/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove Item")]
    public class RemoveItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove Item";

        public override System.Type Type => typeof(Thor.RemoveItem);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.SharedDataObject m_data;

        [GraphProcessor.Input("Force"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_force;

        [GraphProcessor.Input("Drop"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_drop;

        [GraphProcessor.Input("Dropped Output")]
        public Thor.SharedEntity m_droppedOutput;

    }
}
