/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Nearest Filter")]
    public class NearestFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Nearest Filter";

        public override System.Type Type => typeof(Thor.NearestFilter);

        [GraphProcessor.Input("Input")]
        public Thor.SharedEntityList m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

        [GraphProcessor.Input("Compare With")]
        public Thor.SharedEntity m_compareWith;

        [GraphProcessor.Input("Invert"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_invert;

    }
}
