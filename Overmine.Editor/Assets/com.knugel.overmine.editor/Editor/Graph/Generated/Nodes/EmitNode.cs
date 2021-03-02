/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Emit")]
    public class EmitNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Emit";

        public override System.Type Type => typeof(Thor.Emit);

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        [GraphProcessor.Input("Visual Position"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_visualPosition;

        [GraphProcessor.Input("Scale"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_scale;

        [GraphProcessor.Input("Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_name;

    }
}
