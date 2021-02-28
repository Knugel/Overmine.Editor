/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Do Ability Stage")]
    public class DoAbilityStageNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Do Ability Stage";

        public override System.Type Type => typeof(Thor.DoAbilityStage);

        [GraphProcessor.ShowInInspector]
        public Thor.AbilityStage m_stage;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.ExternalBehavior[] externalBehaviors;

        [GraphProcessor.ShowInInspector]
        public BehaviorDesigner.Runtime.SharedNamedVariable[] variables;

        [GraphProcessor.ShowInInspector]
        public System.Boolean collapsed;

    }
}
