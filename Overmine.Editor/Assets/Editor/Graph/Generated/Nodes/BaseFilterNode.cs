/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Base Filter")]
    public class BaseFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Base Filter";

        public override System.Type Type => typeof(Thor.BaseFilter);

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
