/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Distance Filter")]
    public class DistanceFilterNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Distance Filter";

        public override System.Type Type => typeof(Thor.DistanceFilter);

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_offset;

        [GraphProcessor.ShowInInspector]
        public UnityEngine.Space m_offsetSpace;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_invert;

        [GraphProcessor.Input("Distance"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_distance;

        [GraphProcessor.Input("Flatten Y"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_flattenY;

        [GraphProcessor.Input("Input")]
        public BehaviorDesigner.Runtime.SharedVariable m_input;

        [GraphProcessor.Input("Output")]
        public Thor.SharedEntityList m_output;

    }
}
