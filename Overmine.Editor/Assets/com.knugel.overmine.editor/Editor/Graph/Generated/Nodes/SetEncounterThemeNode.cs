/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Set Encounter Theme")]
    public class SetEncounterThemeNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Set Encounter Theme";

        public override System.Type Type => typeof(Thor.SetEncounterTheme);

        [GraphProcessor.Input("Theme"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_theme;

    }
}
