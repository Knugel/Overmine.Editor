/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Drink Potion")]
    public class DrinkPotionNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Drink Potion";

        public override System.Type Type => typeof(Thor.DrinkPotion);

        [GraphProcessor.Input("Start Position"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedVector3 m_startPosition;

        [GraphProcessor.Input("Missile")]
        public Thor.MissileExt m_missile;

    }
}
