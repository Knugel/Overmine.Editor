/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Loot")]
    public class AddLootNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Loot";

        public override System.Type Type => typeof(Thor.AddLoot);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Loot")]
        public Thor.Spawner.SpawnTable m_loot;

    }
}
