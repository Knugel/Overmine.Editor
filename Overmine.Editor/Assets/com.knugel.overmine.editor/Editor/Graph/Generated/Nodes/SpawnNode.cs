/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Spawn")]
    public class SpawnNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Spawn";

        public override System.Type Type => typeof(Thor.Spawn);

        [GraphProcessor.Input("Target Data")]
        public Thor.Spawn.TargetData m_targetData;

        [GraphProcessor.Input("Entity")]
        public Thor.SharedEntity m_entity;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

        [GraphProcessor.Input("Output List")]
        public Thor.SharedEntityList m_outputList;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        [GraphProcessor.Input("Rotation"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_rotation;

        [GraphProcessor.Input("Scale"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_scale;

        [GraphProcessor.Input("Owner")]
        public Thor.SharedEntity m_owner;

        [GraphProcessor.Input("Link")]
        public Thor.SharedEntity m_link;

        [GraphProcessor.Input("Match Rotation")]
        public Thor.SharedEntity m_matchRotation;

        [GraphProcessor.Input("Flatten Y"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_flattenY;

        [GraphProcessor.Input("Walkable"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_walkable;

        [GraphProcessor.Input("Match Visual"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_matchVisual;

        [GraphProcessor.Input("As Minion"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_asMinion;

        [GraphProcessor.Input("Play Spawn Animation"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_playSpawnAnimation;

    }
}
