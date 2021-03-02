/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Look At Target")]
    public class LookAtTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Look At Target";

        public override System.Type Type => typeof(Thor.LookAtTarget);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Point"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_point;

    }
}
