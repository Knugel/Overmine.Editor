/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Change Resource")]
    public class ChangeResourceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Change Resource";

        public override System.Type Type => typeof(Thor.ChangeResource);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.ResourceData m_resource;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

        [GraphProcessor.Input("Allow Partial"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_allowPartial;

        [GraphProcessor.Input("Silent"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_silent;

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

    }
}
