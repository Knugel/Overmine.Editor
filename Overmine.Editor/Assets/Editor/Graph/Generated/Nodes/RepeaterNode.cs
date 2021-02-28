/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Repeater")]
    public class RepeaterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Repeater";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.Repeater);

        [GraphProcessor.Input("Count"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt count;

        [GraphProcessor.Input("Repeat Forever"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool repeatForever;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool endOnFailure;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
