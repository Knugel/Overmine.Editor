using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Property Setter")]
    public class PropertySetterNode : BaseNode
    {
        [ShowInInspector]
        public string TypeName;
        
        [ShowInInspector]
        public string MemberName;
        
        [ShowInInspector]
        public string OperatorName;
        
        [ShowInInspector]
        public string Value;
        
        [Input("Value"), ShowAsDrawer]
        public SharedBool BoolValue;
        
        [Input("Value"), ShowAsDrawer]
        public SharedInt IntValue;
        
        [Input("Value"), ShowAsDrawer]
        public SharedFloat FloatValue;
        
        [Input("Value"), ShowAsDrawer]
        public SharedString StringValue = new SharedString();
        
        [Input("Value"), ShowAsDrawer]
        public SharedVector3 Vector3Value;
        
        [Input("Value")]
        public SharedEntity EntityValue;
        
        [Input("Value"), ShowAsDrawer]
        public SharedColor ColorValue;
        
        [Input("Value")]
        public SharedDataObject DataObjectValue;

        [Output("Out")]
        public PropertySetter Output;

        public override string name => "Property Setter";

        protected override void Process()
        {
            Output = new PropertySetter
            {
                typeName = TypeName,
                memberName = MemberName,
                operatorName = OperatorName,
                value = Value,
                boolValue = BoolValue,
                intValue = IntValue,
                floatValue = FloatValue,
                stringValue = StringValue,
                vector3Value = Vector3Value,
                entityValue = EntityValue,
                colorValue = ColorValue,
                dataObjectValue = DataObjectValue
            };
        }
    }
}