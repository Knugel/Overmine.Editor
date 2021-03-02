/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fire Custom Sim Event")]
    public class FireCustomSimEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fire Custom Sim Event";

        public override System.Type Type => typeof(Thor.FireCustomSimEvent);

        [GraphProcessor.Input("Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_name;

        [GraphProcessor.Input("Data")]
        public Thor.SharedEntity m_data;

    }
}
