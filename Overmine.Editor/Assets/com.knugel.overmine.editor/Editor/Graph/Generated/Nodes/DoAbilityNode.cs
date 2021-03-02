/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Do Ability")]
    public class DoAbilityNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Do Ability";

        public override System.Type Type => typeof(Thor.DoAbility);

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.Tasks.AbortType abortType;

        [GraphProcessor.Output, GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
