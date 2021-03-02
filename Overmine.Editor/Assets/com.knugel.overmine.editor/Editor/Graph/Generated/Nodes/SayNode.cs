/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Say")]
    public class SayNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Say";

        public override System.Type Type => typeof(Thor.Say);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Loc ID")]
        public Thor.LocID m_locID;

        [GraphProcessor.Input("Duration"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_duration;

        [GraphProcessor.ShowInInspector]
        public Thor.Say.SayJustify m_justify;

        [GraphProcessor.Input("Silent"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_silent;

    }
}
