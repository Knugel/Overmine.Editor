/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Exited Collision")]
    public class HasExitedCollisionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Exited Collision";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.HasExitedCollision);

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString tag;

        [GraphProcessor.Input("Collided Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject collidedGameObject;

    }
}
