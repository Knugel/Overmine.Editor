using GraphProcessor;

namespace Editor.Graph.Nodes
{
    [System.Serializable, NodeMenuItem("Entry")]
    public class EntryTaskNode : BaseNode
    {
        [Output(allowMultiple = false), Vertical]
        public ControlFlow Out;

        public override string name => "Entry";
    }
}