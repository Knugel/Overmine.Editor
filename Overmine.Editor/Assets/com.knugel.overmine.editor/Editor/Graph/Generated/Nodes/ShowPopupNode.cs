/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Show Popup")]
    public class ShowPopupNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Show Popup";

        public override System.Type Type => typeof(Thor.ShowPopup);

        [GraphProcessor.Input("Data")]
        public Thor.Popup.PopupData m_data;

        [GraphProcessor.Input("Target")]
        public Thor.TargetData m_target;

        [GraphProcessor.Input("Owner")]
        public Thor.SharedEntity m_owner;

        [GraphProcessor.Input("Follow")]
        public Thor.SharedEntity m_follow;

        [GraphProcessor.Input("Wait For Hint"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_waitForHint;

        [GraphProcessor.Input("Result"), GraphProcessor.ShowAsDrawer]
        public BehaviorDesigner.Runtime.SharedString m_result;

    }
}
