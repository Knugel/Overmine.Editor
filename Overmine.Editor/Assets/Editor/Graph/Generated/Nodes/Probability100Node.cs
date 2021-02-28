/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Probability100")]
    public class Probability100Node : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Probability100";

        public override System.Type Type => typeof(Thor.Probability100);

        [GraphProcessor.Input("Probability"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_probability;

    }
}
