/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add External Behaviors")]
    public class AddExternalBehaviorsNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add External Behaviors";

        public override System.Type Type => typeof(Thor.AddExternalBehaviors);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("External Behaviors")]
        public Thor.BehaviorContainer m_externalBehaviors;

    }
}
