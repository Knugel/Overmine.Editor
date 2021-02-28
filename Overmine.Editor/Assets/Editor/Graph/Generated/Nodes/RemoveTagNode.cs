/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove Tag")]
    public class RemoveTagNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove Tag";

        public override System.Type Type => typeof(Thor.RemoveTag);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.Tag m_tag;

    }
}
