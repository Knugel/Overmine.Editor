/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Has Scratch")]
    public class HasScratchNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Has Scratch";

        public override System.Type Type => typeof(Thor.HasScratch);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Scratch"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_scratch;

        [GraphProcessor.Input("Invert"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_invert;

    }
}
