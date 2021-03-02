/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Copy Loot")]
    public class CopyLootNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Copy Loot";

        public override System.Type Type => typeof(Thor.CopyLoot);

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Source Hint"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_sourceHint;

        [GraphProcessor.Input("Destination")]
        public Thor.SharedEntity m_destination;

        [GraphProcessor.Input("Destination Hint"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_destinationHint;

    }
}
