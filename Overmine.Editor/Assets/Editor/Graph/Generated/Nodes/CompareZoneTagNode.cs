/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Zone Tag")]
    public class CompareZoneTagNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Zone Tag";

        public override System.Type Type => typeof(Thor.CompareZoneTag);

        [GraphProcessor.Input("Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_tag;

    }
}
