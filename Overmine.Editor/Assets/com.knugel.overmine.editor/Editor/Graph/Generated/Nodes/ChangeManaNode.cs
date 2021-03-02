/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Change Mana")]
    public class ChangeManaNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Change Mana";

        public override System.Type Type => typeof(Thor.ChangeMana);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Amount"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedInt m_amount;

    }
}
