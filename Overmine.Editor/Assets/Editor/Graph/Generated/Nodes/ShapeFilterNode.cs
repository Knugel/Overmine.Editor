/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Shape Filter")]
    public class ShapeFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Shape Filter";

        public override System.Type Type => typeof(Thor.ShapeFilter);

        [GraphProcessor.Input("Position Output")]
        public Thor.SharedVector3List m_positionOutput;

        [GraphProcessor.Input("Compare With")]
        public Thor.SharedEntity m_compareWith;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        public Thor.ShapeFilter.Data m_data;

        public UnityEngine.LayerMask m_layerMask;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.QueryTriggerInteraction m_triggerInteraction;

        public UnityEngine.AnimationCurve m_coneCurve;

        [GraphProcessor.Input("Invert Curve"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_invertCurve;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
