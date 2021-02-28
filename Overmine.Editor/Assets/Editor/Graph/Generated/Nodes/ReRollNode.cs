/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Re Roll")]
    public class ReRollNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Re Roll";

        public override System.Type Type => typeof(Thor.ReRoll);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        public Thor.LootTableData m_lootTable;

    }
}
