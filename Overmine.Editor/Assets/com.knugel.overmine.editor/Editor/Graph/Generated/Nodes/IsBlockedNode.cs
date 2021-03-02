/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Is Blocked")]
    public class IsBlockedNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Is Blocked";

        public override System.Type Type => typeof(Thor.IsBlocked);

        [GraphProcessor.Input("Mover")]
        public Thor.SharedEntity m_mover;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

    }
}
