/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Invoke Method")]
    public class InvokeMethodNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Invoke Method";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.InvokeMethod);

        [GraphProcessor.Input("Target Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject targetGameObject;

        [GraphProcessor.Input("Component Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString componentName;

        [GraphProcessor.Input("Method Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString methodName;

        [GraphProcessor.Input("Parameter1")]
        public BehaviorDesigner.Runtime.SharedVariable parameter1;

        [GraphProcessor.Input("Parameter2")]
        public BehaviorDesigner.Runtime.SharedVariable parameter2;

        [GraphProcessor.Input("Parameter3")]
        public BehaviorDesigner.Runtime.SharedVariable parameter3;

        [GraphProcessor.Input("Parameter4")]
        public BehaviorDesigner.Runtime.SharedVariable parameter4;

        [GraphProcessor.Input("Store Result")]
        public BehaviorDesigner.Runtime.SharedVariable storeResult;

    }
}
