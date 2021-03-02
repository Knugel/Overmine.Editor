/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Can Throw")]
    public class CanThrowNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Can Throw";

        public override System.Type Type => typeof(Thor.CanThrow);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        public UnityEngine.LayerMask m_layerMask;

        [GraphProcessor.Input("Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_distance;

    }
}
