/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Compare Game State")]
    public class CompareGameStateNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Compare Game State";

        public override System.Type Type => typeof(Thor.CompareGameState);

        [GraphProcessor.ShowInInspector]
        public Thor.Game.GameState m_state;

        [GraphProcessor.Input("Invert"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_invert;

    }
}
