/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Add Zone Cost Modifier")]
    public class AddZoneCostModifierNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Add Zone Cost Modifier";

        public override System.Type Type => typeof(Thor.AddZoneCostModifier);

        [GraphProcessor.Input("Modifier")]
        public Thor.ResourceManager.ResourceModifier m_modifier;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_dynamicID;

        [GraphProcessor.ShowInInspector]
        public System.Boolean m_removeOnComplete;

    }
}
