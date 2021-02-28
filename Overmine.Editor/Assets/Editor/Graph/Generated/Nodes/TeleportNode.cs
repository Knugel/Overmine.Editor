/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Teleport")]
    public class TeleportNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Teleport";

        public override System.Type Type => typeof(Thor.Teleport);

        [GraphProcessor.Input("Teleportee")]
        public Thor.SharedEntity m_teleportee;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        [GraphProcessor.Input("Flatten Y"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_flattenY;

        [GraphProcessor.Input("Walkable"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_walkable;

    }
}
