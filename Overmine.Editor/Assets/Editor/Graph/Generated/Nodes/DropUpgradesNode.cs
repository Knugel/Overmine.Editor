/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Drop Upgrades")]
    public class DropUpgradesNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Drop Upgrades";

        public override System.Type Type => typeof(Thor.DropUpgrades);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        public Thor.ItemData m_bottle;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_maxWeapons;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_maxGloves;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_maxTunics;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_maxRange;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_maxBombs;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_maxBottles;

        public Thor.Entity m_templateOverride;

        [GraphProcessor.ShowInInspector]
        public System.Int32 m_points;

    }
}
