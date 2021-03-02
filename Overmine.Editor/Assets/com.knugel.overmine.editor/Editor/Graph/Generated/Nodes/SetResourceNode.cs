/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Resource")]
    public class SetResourceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Resource";

        public override System.Type Type => typeof(Thor.SetResource);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Resource")]
        public Thor.ResourceData m_resource;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
