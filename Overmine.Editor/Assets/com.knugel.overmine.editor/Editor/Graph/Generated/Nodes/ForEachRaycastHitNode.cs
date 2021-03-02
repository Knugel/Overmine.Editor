/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("For Each Raycast Hit")]
    public class ForEachRaycastHitNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "For Each Raycast Hit";

        public override System.Type Type => typeof(Thor.ForEachRaycastHit);

        [GraphProcessor.Input("Input")]
        public Thor.SharedEntityList m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

        [GraphProcessor.Input("Entity Output")]
        public Thor.SharedEntity m_entityOutput;

        [GraphProcessor.Input("Position Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_positionOutput;

        [GraphProcessor.Input("Compare With")]
        public Thor.SharedEntity m_compareWith;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        public Thor.ForEachRaycastHit.Data m_data;

        public Thor.ForEachRaycastHit.Data m_dataSecondary;

        public UnityEngine.LayerMask m_layerMask;

        public UnityEngine.LayerMask m_layerMaskSecondary;

        public UnityEngine.AnimationCurve m_coneCurve;

        [GraphProcessor.Output(allowMultiple = false), GraphProcessor.Vertical]
        public Editor.Graph.Nodes.ControlFlow Children;
    }
}
