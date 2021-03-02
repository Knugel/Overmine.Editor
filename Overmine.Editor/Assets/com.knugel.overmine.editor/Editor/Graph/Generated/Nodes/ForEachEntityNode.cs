/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("For Each Entity")]
    public class ForEachEntityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "For Each Entity";

        public override System.Type Type => typeof(Thor.ForEachEntity);

        [GraphProcessor.Input("Input")]
        public Thor.SharedEntityList m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Input("Reverse"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_reverse;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
