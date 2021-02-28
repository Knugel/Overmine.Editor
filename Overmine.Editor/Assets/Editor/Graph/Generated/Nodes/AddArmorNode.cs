/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Armor")]
    public class AddArmorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Armor";

        public override System.Type Type => typeof(Thor.AddArmor);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.ShowInInspector]
        public Thor.HealthExt.Armor m_armor;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_removeOnComplete;

    }
}
