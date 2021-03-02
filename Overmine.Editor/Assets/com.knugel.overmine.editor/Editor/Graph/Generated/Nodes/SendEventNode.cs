/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Send Event")]
    public class SendEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Send Event";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.SendEvent);

        [GraphProcessor.Input("Target Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject targetGameObject;

        [GraphProcessor.Input("Event Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString eventName;

        [GraphProcessor.Input("Group"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt group;

        [GraphProcessor.Input("Argument1")]
        public BehaviorDesigner.Runtime.SharedVariable argument1;

        [GraphProcessor.Input("Argument2")]
        public BehaviorDesigner.Runtime.SharedVariable argument2;

        [GraphProcessor.Input("Argument3")]
        public BehaviorDesigner.Runtime.SharedVariable argument3;

    }
}
