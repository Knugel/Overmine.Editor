/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Rotation")]
    public class SetRotationNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Rotation";

        public override System.Type Type => typeof(Thor.SetRotation);

        [GraphProcessor.Input("Rotator")]
        public Thor.SharedEntity m_rotator;

        [GraphProcessor.Input("Angles"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_angles;

    }
}
