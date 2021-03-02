/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Ignore Collision")]
    public class IgnoreCollisionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Ignore Collision";

        public override System.Type Type => typeof(Thor.IgnoreCollision);

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Ignore"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_ignore;

    }
}
