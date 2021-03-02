/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Rotate To Reflection")]
    public class RotateToReflectionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Rotate To Reflection";

        public override System.Type Type => typeof(Thor.RotateToReflection);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Reflection"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_reflection;

    }
}
