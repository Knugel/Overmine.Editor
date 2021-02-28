/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Format Loc String")]
    public class FormatLocStringNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Format Loc String";

        public override System.Type Type => typeof(Thor.FormatLocString);

        [GraphProcessor.Input("Loc ID")]
        public Thor.LocID m_locID;

        [GraphProcessor.Input("Argument")]
        public BehaviorDesigner.Runtime.SharedVariable m_argument;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedString m_output;

    }
}
