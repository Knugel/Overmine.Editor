/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Spawn Player")]
    public class SpawnPlayerNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Spawn Player";

        public override System.Type Type => typeof(Thor.SpawnPlayer);

        [GraphProcessor.Input("Spawn Trigger"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_spawnTrigger;

    }
}
