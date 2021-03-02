/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Fade Hud")]
    public class FadeHudNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Fade Hud";

        public override System.Type Type => typeof(Thor.FadeHud);

        [GraphProcessor.ShowInInspector]
        public Thor.FadeHud.FadeDirection m_direction;

    }
}
