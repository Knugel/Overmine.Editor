/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Load Zone")]
    public class LoadZoneNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Load Zone";

        public override System.Type Type => typeof(Thor.LoadZone);

        public Thor.ZoneData m_zone;

        [GraphProcessor.ShowInInspector]
        public Thor.Direction m_direction;

        [GraphProcessor.Input("Hint"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_hint;

    }
}
