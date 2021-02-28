/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Obfuscate")]
    public class ObfuscateNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Obfuscate";

        public override System.Type Type => typeof(Thor.Obfuscate);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Obfuscate"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_obfuscate;

    }
}
