/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Drop Item")]
    public class DropItemNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Drop Item";

        public override System.Type Type => typeof(Thor.DropItem);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Jump"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_jump;

        [GraphProcessor.Input("Auto Carry"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_autoCarry;

        [GraphProcessor.ShowInInspector]
        public Thor.Rand.StateType m_tableRandState;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        public Thor.Entity m_templateOverride;

        [GraphProcessor.Input("Data")]
        public Thor.DropItem.DropItemData m_data;

    }
}
