/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Copy Modifiers")]
    public class CopyModifiersNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Copy Modifiers";

        public override System.Type Type => typeof(Thor.CopyModifiers);

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Destination")]
        public Thor.SharedEntity m_destination;

    }
}
