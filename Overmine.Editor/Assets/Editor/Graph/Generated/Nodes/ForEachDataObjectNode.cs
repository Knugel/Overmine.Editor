/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("For Each Data Object")]
    public class ForEachDataObjectNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "For Each Data Object";

        public override System.Type Type => typeof(Thor.ForEachDataObject);

        [GraphProcessor.Input("Input")]
        public Thor.SharedDataObjectList m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedDataObject m_output;

        [GraphProcessor.Input("Reverse"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_reverse;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
