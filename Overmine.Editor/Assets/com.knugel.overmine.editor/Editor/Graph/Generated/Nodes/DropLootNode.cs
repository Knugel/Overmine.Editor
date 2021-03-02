/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Drop Loot")]
    public class DropLootNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Drop Loot";

        public override System.Type Type => typeof(Thor.DropLoot);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Hint"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_hint;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_space;

    }
}
