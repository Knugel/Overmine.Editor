/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Stop Audio")]
    public class StopAudioNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Stop Audio";

        public override System.Type Type => typeof(Thor.StopAudio);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

    }
}
