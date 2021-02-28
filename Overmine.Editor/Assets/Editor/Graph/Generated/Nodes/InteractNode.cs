/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Interact")]
    public class InteractNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Interact";

        public override System.Type Type => typeof(Thor.Interact);

        [GraphProcessor.Input("Target")]
        public Thor.SharedEntity m_target;

        [GraphProcessor.Input("Interactor")]
        public Thor.SharedEntity m_interactor;

        [GraphProcessor.ShowInInspector]
        public Thor.InteractableExt.InteractionState m_state;

    }
}
