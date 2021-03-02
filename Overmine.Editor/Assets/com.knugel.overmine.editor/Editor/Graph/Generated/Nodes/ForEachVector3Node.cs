/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("For Each Vector3")]
    public class ForEachVector3Node : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "For Each Vector3";

        public override System.Type Type => typeof(Thor.ForEachVector3);

        [GraphProcessor.Input("Input")]
        public Thor.SharedVector3List m_input;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

        [GraphProcessor.Input("Reverse"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_reverse;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
