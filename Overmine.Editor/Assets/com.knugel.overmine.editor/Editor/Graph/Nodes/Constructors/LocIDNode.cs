using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Loc ID")]
    public class LocIDNode : BaseNode
    {
        [Input("ID"), ShowAsDrawer]
        public int ID;

        [Input("Text"), ShowAsDrawer]
        public SharedString Text;

        [Output("Out")]
        public LocID Output;
        
        public override string name => "Loc ID";
        
        protected override void Process()
        {
            Output = new LocID
            {
                Id = ID,
                Text = Text
            };
        }
    }
}