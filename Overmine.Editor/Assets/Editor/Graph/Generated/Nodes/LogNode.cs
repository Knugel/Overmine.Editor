/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Log")]
    public class LogNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Log";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.Log);

        [GraphProcessor.Input("Text"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString text;

        [GraphProcessor.Input("Log Error"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool logError;

    }
}
