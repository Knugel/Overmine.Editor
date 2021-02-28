/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Remove Armor")]
    public class RemoveArmorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Remove Armor";

        public override System.Type Type => typeof(Thor.RemoveArmor);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public System.String m_id;

    }
}
