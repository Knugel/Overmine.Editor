/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Copy Equipment")]
    public class CopyEquipmentNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Copy Equipment";

        public override System.Type Type => typeof(Thor.CopyEquipment);

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Destination")]
        public Thor.SharedEntity m_destination;

    }
}
