/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Property Change Filter")]
    public class PropertyChangeFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Property Change Filter";

        public override System.Type Type => typeof(Thor.PropertyChangeFilter);

        [GraphProcessor.ShowInInspector]
        public Thor.PropertyObserver m_observer;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
