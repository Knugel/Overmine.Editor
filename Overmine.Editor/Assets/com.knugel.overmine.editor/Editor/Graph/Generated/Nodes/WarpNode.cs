/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Warp")]
    public class WarpNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Warp";

        public override System.Type Type => typeof(Thor.Warp);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Encounter Tag"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_encounterTag;

        [GraphProcessor.ShowInInspector]
        public Thor.Direction m_direction;

    }
}
