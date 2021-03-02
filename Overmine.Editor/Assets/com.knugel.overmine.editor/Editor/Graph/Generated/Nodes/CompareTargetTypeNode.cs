/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Target Type")]
    public class CompareTargetTypeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Target Type";

        public override System.Type Type => typeof(Thor.CompareTargetType);

        [GraphProcessor.Input("Target Type")]
        public BehaviorDesigner.Runtime.SharedTargetType m_targetType;

        [GraphProcessor.Input("Compare To")]
        public BehaviorDesigner.Runtime.SharedTargetType m_compareTo;

    }
}
