/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Talk")]
    public class TalkNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Talk";

        public override System.Type Type => typeof(Thor.Talk);

        [GraphProcessor.Input("Avatar")]
        public Thor.SharedEntity m_avatar;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Loc ID")]
        public Thor.LocID m_locID;

        [GraphProcessor.ShowInInspector]
        public Thor.Talk.TalkStyle m_style;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector2 m_offset;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_faceTarget;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_restoreFacing;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<BehaviorDesigner.Runtime.SharedVariable> m_arguments;

    }
}
