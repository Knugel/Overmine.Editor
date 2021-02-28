/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Game Option")]
    public class CompareGameOptionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Game Option";

        public override System.Type Type => typeof(Thor.CompareGameOption);

        [GraphProcessor.ShowInInspector]
        public Thor.CompareGameOption.GameOption m_option;

    }
}
