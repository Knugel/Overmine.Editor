/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Index Filter")]
    public class IndexFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Index Filter";

        public override System.Type Type => typeof(Thor.IndexFilter);

        [GraphProcessor.Input("Input")]
        public Thor.SharedEntityList m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntity m_output;

        [GraphProcessor.Input("Index"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_index;

    }
}
