/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Change H P Result")]
    public class CompareChangeHPResultNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Change H P Result";

        public override System.Type Type => typeof(Thor.CompareChangeHPResult);

        [GraphProcessor.Input("Change H P Result")]
        public BehaviorDesigner.Runtime.SharedChangeHPResult m_changeHPResult;

        [GraphProcessor.Input("Compare To")]
        public BehaviorDesigner.Runtime.SharedChangeHPResult m_compareTo;

    }
}
