/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Property Value")]
    public class ComparePropertyValueNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Property Value";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.ComparePropertyValue);

        [GraphProcessor.Input("Target Game Object")]
        public BehaviorDesigner.Runtime.SharedGameObject targetGameObject;

        [GraphProcessor.Input("Component Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString componentName;

        [GraphProcessor.Input("Property Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString propertyName;

        [GraphProcessor.Input("Compare Value")]
        public BehaviorDesigner.Runtime.SharedVariable compareValue;

    }
}
