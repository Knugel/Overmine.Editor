/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Is Unlocked")]
    public class IsUnlockedNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Is Unlocked";

        public override System.Type Type => typeof(Thor.IsUnlocked);

        [GraphProcessor.Input("Target")]
        public Thor.SharedDataObject m_target;

    }
}
