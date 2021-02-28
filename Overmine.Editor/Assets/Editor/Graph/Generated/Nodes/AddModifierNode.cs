/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Modifier")]
    public class AddModifierNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Modifier";

        public override System.Type Type => typeof(Thor.AddModifier);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Modifier")]
        public Thor.Modifier m_modifier;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_dynamicID;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_removeOnComplete;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_isBase;

    }
}
