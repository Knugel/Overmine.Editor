using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Damage Data")]
    public class DamageDataNode : BaseNode
    {
        [ShowInInspector]
        public DamageExt.DamageCategory Category;

        [Input("Custom Amount"), ShowAsDrawer]
        public SharedInt CustomAmount;

        [Input("Custom Type"), ShowAsDrawer]
        public SharedDamageType CustomType;

        [Input("Multiplier"), ShowAsDrawer]
        public SharedFloat Multiplier = 1f;
        
        [ShowInInspector]
        public HealthExt.ChangeHPResult SucceedOn = HealthExt.ChangeHPResult.Success | HealthExt.ChangeHPResult.Absorbed;
        
        [Output("Out")]
        public DamageTarget.DamageData Output;

        public override string name => "Damage Data";

        protected override void Process()
        {
            Output = new DamageTarget.DamageData
            {
                category = Category,
                multiplier = Multiplier,
                customAmount = CustomAmount,
                customType = CustomType,
                succeedOn = SucceedOn
            };
        }
    }
}