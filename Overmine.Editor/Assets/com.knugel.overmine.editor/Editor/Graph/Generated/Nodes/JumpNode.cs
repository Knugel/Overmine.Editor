/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Jump")]
    public class JumpNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Jump";

        public override System.Type Type => typeof(Thor.Jump);

        [GraphProcessor.Input("Jumper")]
        public Thor.SharedEntity m_jumper;

        [GraphProcessor.Input("Force"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_force;

        [GraphProcessor.Input("Boost"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_boost;

        [GraphProcessor.Input("Ignore Restrictions"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_ignoreRestrictions;

        [GraphProcessor.Input("Silent"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_silent;

    }
}
