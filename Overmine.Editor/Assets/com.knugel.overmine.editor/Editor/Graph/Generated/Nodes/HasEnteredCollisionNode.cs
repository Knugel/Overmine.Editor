/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Entered Collision")]
    public class HasEnteredCollisionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Entered Collision";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.HasEnteredCollision);

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString tag;

        [GraphProcessor.Input("Collided Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject collidedGameObject;

    }
}
