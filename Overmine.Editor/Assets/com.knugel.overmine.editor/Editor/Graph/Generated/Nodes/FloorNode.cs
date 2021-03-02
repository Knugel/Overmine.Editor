/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Floor")]
    public class FloorNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Floor";

        public override System.Type Type => typeof(Thor.Floor);

        [GraphProcessor.Input("Value"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedFloat m_value;

    }
}
