/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Behavior Tree Reference")]
    public class BehaviorTreeReferenceNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Behavior Tree Reference";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.BehaviorTreeReference);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.ExternalBehavior[] externalBehaviors;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.SharedNamedVariable[] variables;

        [GraphProcessor.ShowInInspector]
        public System.Boolean collapsed;

    }
}
