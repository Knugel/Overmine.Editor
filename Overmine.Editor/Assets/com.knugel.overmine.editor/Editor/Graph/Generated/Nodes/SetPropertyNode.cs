/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Property")]
    public class SetPropertyNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Property";

        public override System.Type Type => typeof(Thor.SetProperty);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Setter")]
        public Thor.PropertySetter m_setter;

    }
}
