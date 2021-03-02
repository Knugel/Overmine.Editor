/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Bless")]
    public class BlessNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Bless";

        public override System.Type Type => typeof(Thor.Bless);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Source")]
        public Thor.SharedEntity m_source;

        [GraphProcessor.Input("Increment Existing"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_incrementExisting;

    }
}
