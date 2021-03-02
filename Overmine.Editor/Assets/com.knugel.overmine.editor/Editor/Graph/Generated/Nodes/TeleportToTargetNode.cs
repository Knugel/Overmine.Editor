/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Teleport To Target")]
    public class TeleportToTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Teleport To Target";

        public override System.Type Type => typeof(Thor.TeleportToTarget);

        [GraphProcessor.Input("Teleportee")]
        public Thor.SharedEntity m_teleportee;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Target Position"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_targetPosition;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.Input("Flatten Y"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_flattenY;

    }
}
