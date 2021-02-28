/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Encounter Icon")]
    public class SetEncounterIconNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Encounter Icon";

        public override System.Type Type => typeof(Thor.SetEncounterIcon);

        [GraphProcessor.Input("Icon")]
        public UnityEngine.Sprite m_icon;

    }
}
