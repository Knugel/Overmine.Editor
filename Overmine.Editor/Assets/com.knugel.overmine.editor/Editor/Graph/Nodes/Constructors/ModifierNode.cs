using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Modifier")]
    public class ModifierNode : BaseNode
    {
        [ShowInInspector]
        public string Id;
        
        [ShowInInspector]
        public string TypeName;
        
        [ShowInInspector]
        public string MemberName;
        
        [ShowInInspector]
        public string OperatorName;
        
        [Input("Bool Amount"), ShowAsDrawer]
        public SharedBool BoolAmount = false;
        
        [Input("Float Amount"), ShowAsDrawer]
        public SharedFloat FloatAmount = 0.0f;
        
        [ShowInInspector]
        public int Order;
        
        [ShowInInspector]
        public string Link;
        
        [ShowInInspector]
        public bool Autosave;
        
        [Output("Out")]
        public Modifier Output;
        
        public override string name => "Modifier";

        protected override void Process()
        {
            Output = new Modifier
            {
                id = Id,
                typeName = TypeName,
                memberName = MemberName,
                operatorName = OperatorName,
                boolAmount = BoolAmount,
                floatAmount = FloatAmount,
                order = Order,
                link = Link,
                autosave = Autosave
            };
        }
    }
}