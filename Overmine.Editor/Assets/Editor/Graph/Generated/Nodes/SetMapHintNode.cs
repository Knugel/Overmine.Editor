/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Map Hint")]
    public class SetMapHintNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Map Hint";

        public override System.Type Type => typeof(Thor.SetMapHint);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.Room.MapHintType m_hint;

    }
}
