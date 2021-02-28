/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Pray")]
    public class PrayNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Pray";

        public override System.Type Type => typeof(Thor.Pray);

        [GraphProcessor.Input("Avatar")]
        public Thor.SharedEntity m_avatar;

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Count"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_count;

        [GraphProcessor.Input("Blessing Output")]
        public Thor.SharedDataObject m_blessingOutput;

    }
}
