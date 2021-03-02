/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Show Boss HP")]
    public class ShowBossHPNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Show Boss HP";

        public override System.Type Type => typeof(Thor.ShowBossHP);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Level Upgrade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_levelUpgrade;

        [GraphProcessor.Input("Timed"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_timed;

    }
}
