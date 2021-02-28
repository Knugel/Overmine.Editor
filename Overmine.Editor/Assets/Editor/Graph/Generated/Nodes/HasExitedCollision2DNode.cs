/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Exited Collision2 D")]
    public class HasExitedCollision2DNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Exited Collision2 D";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.HasExitedCollision2D);

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString tag;

        [GraphProcessor.Input("Collided Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject collidedGameObject;

    }
}
