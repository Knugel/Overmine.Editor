/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Play Music")]
    public class PlayMusicNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Play Music";

        public override System.Type Type => typeof(Thor.PlayMusic);

        [GraphProcessor.ShowInInspector]
        public System.String m_name;

        [GraphProcessor.Input("Zone Music"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_zoneMusic;

        [GraphProcessor.Input("Crossfade"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedBool m_crossfade;

    }
}
