/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Entered Trigger2D")]
    public class HasEnteredTrigger2DNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Entered Trigger2D";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.HasEnteredTrigger2D);

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString tag;

        [GraphProcessor.Input("Other Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject otherGameObject;

    }
}
