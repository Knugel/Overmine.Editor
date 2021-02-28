/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Damage Target")]
    public class DamageTargetNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Damage Target";

        public override System.Type Type => typeof(Thor.DamageTarget);

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Data")]
        public Thor.DamageTarget.DamageData m_data;

        [GraphProcessor.Input("Ignore Grace Period"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_ignoreGracePeriod;

        [GraphProcessor.Input("Silent"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_silent;

        [GraphProcessor.Input("Can Crit"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_canCrit;

        [GraphProcessor.Input("Show Kicker"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_showKicker;

        [GraphProcessor.ShowInInspector]
        public Thor.DamagePopup.HintType m_kickerHint;

        [GraphProcessor.Input("Add Variance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_addVariance;

        [GraphProcessor.Input("Result")]
        public BehaviorDesigner.Runtime.SharedChangeHPResult m_result;

        [GraphProcessor.Input("Crit Result"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_critResult;

    }
}
