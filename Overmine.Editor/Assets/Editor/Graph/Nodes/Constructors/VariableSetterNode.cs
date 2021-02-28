using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Variable Setter")]
    public class VariableSetterNode : BaseNode
    {
        [Input("Variable")]
        public SharedVariable SharedVariable;
        
        [ShowInInspector]
        public string OperatorName;
        
        [ShowInInspector]
        public VariableSetter.SetterType SetterType;
        
        [Input("Target")]
        public SharedEntity PropertyTarget;
        
        [ShowInInspector]
        public string PropertyTypeName;
        
        [ShowInInspector]
        public string PropertyMemberName;
        
        [Input("Constant Value")]
        public SharedVariable ConstantValue;

        [Output("Out")]
        public VariableSetter Output;

        public override string name => "Variable Setter";
        
        protected override void Process()
        {
            Output = new VariableSetter
            {
                sharedVariable = SharedVariable,
                operatorName = OperatorName,
                setterType = SetterType,
                propertyTarget = PropertyTarget,
                propertyTypeName = PropertyTypeName,
                propertyMemberName = PropertyMemberName,
                constantValue = ConstantValue
            };
        }
    }
}