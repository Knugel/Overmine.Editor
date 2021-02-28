/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Zap")]
    public class ZapNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Zap";

        public override System.Type Type => typeof(Thor.Zap);

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Source Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_sourceOffset;

        [GraphProcessor.Input("Destination")]
        public Thor.SharedEntity m_destination;

        [GraphProcessor.Input("Destination Offset"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_destinationOffset;

        [GraphProcessor.Input("Sorting Fudge"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_sortingFudge;

        [GraphProcessor.Input("Color")]
        public BehaviorDesigner.Runtime.SharedColor m_color;

        /* The type Thor.Zap.SizeType is private and has been replaced by 'object'!*/
        [GraphProcessor.ShowInInspector]
        public object m_size;

    }
}
