/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Perform Interruption")]
    public class PerformInterruptionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Perform Interruption";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.PerformInterruption);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.Interrupt[] interruptTasks;

        [GraphProcessor.Input("Interrupt Success"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool interruptSuccess;

    }
}
