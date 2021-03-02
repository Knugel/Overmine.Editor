/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Status Effect Level")]
    public class SetStatusEffectLevelNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Status Effect Level";

        public override System.Type Type => typeof(Thor.SetStatusEffectLevel);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Level"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_level;

    }
}
