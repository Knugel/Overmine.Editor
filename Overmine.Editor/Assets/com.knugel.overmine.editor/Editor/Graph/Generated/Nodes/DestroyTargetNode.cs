/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Destroy Target")]
    public class DestroyTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Destroy Target";

        public override System.Type Type => typeof(Thor.DestroyTarget);

        [GraphProcessor.Input("Target")]
        public BehaviorDesigner.Runtime.SharedVariable m_target;

    }
}
