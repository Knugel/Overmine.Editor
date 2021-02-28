/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Blast")]
    public class BlastNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Blast";

        public override System.Type Type => typeof(Thor.Blast);

        [GraphProcessor.Input("Blastee")]
        public Thor.SharedEntity m_blastee;

        [GraphProcessor.Input("Blaster")]
        public Thor.SharedEntity m_blaster;

        public UnityEngine.Sprite m_sprite;

        public UnityEngine.Texture2D m_blastMap;

        [GraphProcessor.Input("Fade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_fade;

    }
}
