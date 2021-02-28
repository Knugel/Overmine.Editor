using GraphProcessor;
using UnityEditor;
using UnityEngine.UIElements;

namespace Editor.Graph.Views
{
    public class BehaviourToolbarView : ToolbarView
    {
        public BehaviourToolbarView(BaseGraphView graphView) : base(graphView)
        {
            
        }

        protected override void AddButtons()
        {
            AddButton("Center", graphView.ResetPositionAndZoom);
            
            var exposedParamsVisible = graphView.GetPinnedElementStatus<BehaviourParameterView>() != DropdownMenuAction.Status.Hidden;
            showParameters = AddToggle("Show Parameters", exposedParamsVisible, (v) => graphView.ToggleView<BehaviourParameterView>());

            AddButton("Show In Project", () => EditorGUIUtility.PingObject(graphView.graph), false);
        }
        
        public override void UpdateButtonStatus()
        {
            if (showParameters != null)
                showParameters.value = graphView.GetPinnedElementStatus<BehaviourParameterView>() != DropdownMenuAction.Status.Hidden;
        }
    }
}