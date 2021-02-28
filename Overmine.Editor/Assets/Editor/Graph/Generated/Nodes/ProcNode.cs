/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Proc")]
    public class ProcNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Proc";

        public override System.Type Type => typeof(Thor.Proc);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Play Audio"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_playAudio;

        [GraphProcessor.Input("Negative"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_negative;

    }
}
