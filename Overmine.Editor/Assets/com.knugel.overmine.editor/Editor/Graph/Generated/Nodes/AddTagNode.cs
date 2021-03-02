/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Tag")]
    public class AddTagNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Tag";

        public override System.Type Type => typeof(Thor.AddTag);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.Tag m_tag;

    }
}
