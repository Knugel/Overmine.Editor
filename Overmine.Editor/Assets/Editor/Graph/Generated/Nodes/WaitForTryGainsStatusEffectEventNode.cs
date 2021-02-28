/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Wait For Try Gains Status Effect Event")]
    public class WaitForTryGainsStatusEffectEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Wait For Try Gains Status Effect Event";

        public override System.Type Type => typeof(Thor.WaitForTryGainsStatusEffectEvent);

        [GraphProcessor.Input("Source Output")]
        public Thor.SharedEntity m_sourceOutput;

        [GraphProcessor.Input("Status Effect Prefab Output")]
        public Thor.SharedEntity m_statusEffectPrefabOutput;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("End On Failure"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_endOnFailure;

        [GraphProcessor.Input("Timeout"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_timeout;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
        [GraphProcessor.Input("Hibernate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_hibernate;

    }
}
