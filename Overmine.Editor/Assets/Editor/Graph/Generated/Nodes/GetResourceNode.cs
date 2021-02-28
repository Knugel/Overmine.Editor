/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Get Resource")]
    public class GetResourceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Get Resource";

        public override System.Type Type => typeof(Thor.GetResource);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.ResourceData m_resource;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedInt m_output;

    }
}
