/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Spawn Decorator")]
    public class SpawnDecoratorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Spawn Decorator";

        public override System.Type Type => typeof(Thor.SpawnDecorator);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Object")]
        public Thor.Decorator m_object;

    }
}
