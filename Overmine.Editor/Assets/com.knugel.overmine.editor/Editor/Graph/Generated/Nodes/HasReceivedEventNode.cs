/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Received Event")]
    public class HasReceivedEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Received Event";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.HasReceivedEvent);

        [GraphProcessor.Input("Event Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString eventName;

        [GraphProcessor.Input("Stored Value1")]
        public BehaviorDesigner.Runtime.SharedVariable storedValue1;

        [GraphProcessor.Input("Stored Value2")]
        public BehaviorDesigner.Runtime.SharedVariable storedValue2;

        [GraphProcessor.Input("Stored Value3")]
        public BehaviorDesigner.Runtime.SharedVariable storedValue3;

    }
}
