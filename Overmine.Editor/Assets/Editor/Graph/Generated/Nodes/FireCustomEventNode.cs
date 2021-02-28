/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fire Custom Event")]
    public class FireCustomEventNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fire Custom Event";

        public override System.Type Type => typeof(Thor.FireCustomEvent);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Name"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_name;

        [GraphProcessor.Input("Data")]
        public Thor.SharedEntity m_data;

        [GraphProcessor.Input("Position"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_position;

    }
}
