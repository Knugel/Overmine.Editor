/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Sort Type")]
    public class AddSortTypeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Sort Type";

        public override System.Type Type => typeof(Thor.AddSortType);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.Entity.SortType m_type;

    }
}
