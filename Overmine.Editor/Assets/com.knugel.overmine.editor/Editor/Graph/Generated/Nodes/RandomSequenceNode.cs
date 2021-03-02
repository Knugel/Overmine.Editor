/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Random Sequence")]
    public class RandomSequenceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Random Sequence";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.RandomSequence);

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
