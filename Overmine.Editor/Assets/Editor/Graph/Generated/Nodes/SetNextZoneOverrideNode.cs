/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Next Zone Override")]
    public class SetNextZoneOverrideNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Next Zone Override";

        public override System.Type Type => typeof(Thor.SetNextZoneOverride);

        [GraphProcessor.Input("Portal")]
        public Thor.SharedEntity m_portal;

    }
}
