/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Game Over")]
    public class GameOverNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Game Over";

        public override System.Type Type => typeof(Thor.GameOver);

        [GraphProcessor.ShowInInspector]
        public Thor.Game.GameOverResult m_result;

        [GraphProcessor.Input("Silent"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_silent;

    }
}
