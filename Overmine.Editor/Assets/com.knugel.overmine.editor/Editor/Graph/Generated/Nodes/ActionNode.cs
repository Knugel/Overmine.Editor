/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Action")]
    public class ActionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Action";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.Action);

        [GraphProcessor.Input("Owner")]
        public BehaviorDesigner.Runtime.Behavior owner;

        [GraphProcessor.ShowInInspector]
        public System.Int32 id;

        [GraphProcessor.ShowInInspector]
        public System.String friendlyName;

        [GraphProcessor.ShowInInspector]
        public System.Boolean instant;

    }
}
