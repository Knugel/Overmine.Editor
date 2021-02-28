/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Start Behavior Tree")]
    public class StartBehaviorTreeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Start Behavior Tree";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.StartBehaviorTree);

        [GraphProcessor.Input("Behavior Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject behaviorGameObject;

        [GraphProcessor.Input("Group"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt group;

        [GraphProcessor.Input("Wait For Completion"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool waitForCompletion;

        [GraphProcessor.Input("Synchronize Variables"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool synchronizeVariables;

    }
}
