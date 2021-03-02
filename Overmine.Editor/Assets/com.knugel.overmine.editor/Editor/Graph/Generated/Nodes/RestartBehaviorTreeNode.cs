/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Restart Behavior Tree")]
    public class RestartBehaviorTreeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Restart Behavior Tree";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.RestartBehaviorTree);

        [GraphProcessor.Input("Behavior Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject behaviorGameObject;

        [GraphProcessor.Input("Group"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt group;

    }
}
