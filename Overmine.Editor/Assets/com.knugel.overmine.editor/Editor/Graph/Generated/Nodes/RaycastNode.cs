/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Raycast")]
    public class RaycastNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Raycast";

        public override System.Type Type => typeof(Thor.Raycast);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Start"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_start;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_startSpace;

        [GraphProcessor.Input("End"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_end;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_endSpace;

        public UnityEngine.LayerMask m_layerMask;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.QueryTriggerInteraction m_triggerInteraction;

    }
}
