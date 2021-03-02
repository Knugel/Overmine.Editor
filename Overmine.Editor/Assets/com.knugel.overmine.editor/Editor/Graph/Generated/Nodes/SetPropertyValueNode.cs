/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Property Value")]
    public class SetPropertyValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Property Value";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.SetPropertyValue);

        [GraphProcessor.Input("Target Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject targetGameObject;

        [GraphProcessor.Input("Component Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString componentName;

        [GraphProcessor.Input("Property Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString propertyName;

        [GraphProcessor.Input("Property Value")]
        public BehaviorDesigner.Runtime.SharedVariable propertyValue;

    }
}
