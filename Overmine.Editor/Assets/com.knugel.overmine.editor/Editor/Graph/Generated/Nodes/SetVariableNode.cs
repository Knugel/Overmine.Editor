/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Variable")]
    public class SetVariableNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Variable";

        public override System.Type Type => typeof(Thor.SetVariable);

        [GraphProcessor.Input("Variable Setter")]
        public Thor.VariableSetter m_variableSetter;

    }
}
