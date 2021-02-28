/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Stop Behavior Tree")]
    public class StopBehaviorTreeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Stop Behavior Tree";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.StopBehaviorTree);

        [GraphProcessor.Input("Behavior Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject behaviorGameObject;

        [GraphProcessor.Input("Group"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt group;

        [GraphProcessor.Input("Pause Behavior"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool pauseBehavior;

    }
}
