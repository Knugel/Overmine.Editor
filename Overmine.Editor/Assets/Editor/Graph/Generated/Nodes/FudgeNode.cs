/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fudge")]
    public class FudgeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fudge";

        public override System.Type Type => typeof(Thor.Fudge);

        [GraphProcessor.Input("Input"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_input;

        [GraphProcessor.Input("Output")]
        public BehaviorDesigner.Runtime.SharedVector3 m_output;

        [GraphProcessor.Input("Fudge"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_fudge;

    }
}
