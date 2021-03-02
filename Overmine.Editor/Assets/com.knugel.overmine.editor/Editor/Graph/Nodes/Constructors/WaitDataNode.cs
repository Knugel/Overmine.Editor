using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Wait Data")]
    public class WaitDataNode : BaseNode
    {
        [Input("Min"), ShowAsDrawer]
        public SharedFloat Min = 1f;
        
        [Input("Max"), ShowAsDrawer]
        public SharedFloat Max = 1f;
        
        [Input("Random"), ShowAsDrawer]
        public SharedBool Random = false;

        [Output("Out")]
        public Wait.Data Output;

        public override string name => "Wait Data";
        
        protected override void Process()
        {
            Output = new Wait.Data
            {
                max = Max,
                min = Min,
                random = Random
            };
        }
    }
}