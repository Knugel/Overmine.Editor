/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Rotate To Visual")]
    public class RotateToVisualNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Rotate To Visual";

        public override System.Type Type => typeof(Thor.RotateToVisual);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
