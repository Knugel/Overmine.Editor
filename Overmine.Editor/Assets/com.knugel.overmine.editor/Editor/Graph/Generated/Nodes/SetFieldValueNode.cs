/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Field Value")]
    public class SetFieldValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Field Value";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.SetFieldValue);

        [GraphProcessor.Input("Target Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject targetGameObject;

        [GraphProcessor.Input("Component Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString componentName;

        [GraphProcessor.Input("Field Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString fieldName;

        [GraphProcessor.Input("Field Value")]
        public BehaviorDesigner.Runtime.SharedVariable fieldValue;

    }
}
