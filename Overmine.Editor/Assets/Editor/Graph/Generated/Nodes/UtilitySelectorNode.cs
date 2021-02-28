/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Utility Selector")]
    public class UtilitySelectorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Utility Selector";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.UtilitySelector);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.AbortType abortType;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
