/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Exited Trigger")]
    public class HasExitedTriggerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Exited Trigger";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.HasExitedTrigger);

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString tag;

        [GraphProcessor.Input("Other Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject otherGameObject;

    }
}
