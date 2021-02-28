/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Random Selector")]
    public class RandomSelectorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Random Selector";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.RandomSelector);

        [GraphProcessor.ShowInInspector]
        public System.Int32 seed;

        [GraphProcessor.ShowInInspector]
        public System.Boolean useSeed;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.AbortType abortType;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
