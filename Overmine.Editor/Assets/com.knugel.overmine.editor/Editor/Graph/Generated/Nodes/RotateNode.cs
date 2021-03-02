/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Rotate")]
    public class RotateNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Rotate";

        public override System.Type Type => typeof(Thor.Rotate);

        [GraphProcessor.Input("Rotator")]
        public Thor.SharedEntity m_rotator;

        [GraphProcessor.Input("Angles"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_angles;

        [GraphProcessor.Input("Snap"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_snap;

    }
}
