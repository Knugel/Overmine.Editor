/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Incremental Selector")]
    public class IncrementalSelectorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Incremental Selector";

        public override System.Type Type => typeof(Thor.IncrementalSelector);

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_resetOnRestart;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.AbortType abortType;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
