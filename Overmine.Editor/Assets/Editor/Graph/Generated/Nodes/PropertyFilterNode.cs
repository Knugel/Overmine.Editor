/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Property Filter")]
    public class PropertyFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Property Filter";

        public override System.Type Type => typeof(Thor.PropertyFilter);

        [GraphProcessor.Input("Compare With")]
        public Thor.SharedEntity m_compareWith;

        [GraphProcessor.ShowInInspector]
        public Thor.PropertyComparer m_comparer;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
