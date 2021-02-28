/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Sign Text")]
    public class SetSignTextNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Sign Text";

        public override System.Type Type => typeof(Thor.SetSignText);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Loc I D")]
        public Thor.LocID m_locID;

    }
}
