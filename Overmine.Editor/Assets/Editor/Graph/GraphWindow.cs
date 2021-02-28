using Editor.Graph.Views;
using GraphProcessor;
using UnityEditor;
using UnityEngine;

namespace Editor.Graph
{
    public class GraphWindow : BaseGraphWindow
    {
        private BaseGraph _tmpGraph;
        private BehaviourToolbarView _toolbarView;

        [MenuItem("Window/Behaviour Graph")]
        public static BaseGraphWindow OpenWithTmpGraph()
        {
            var graphWindow = CreateWindow<GraphWindow>();

            // When the graph is opened from the window, we don't save the graph to disk
            graphWindow._tmpGraph = CreateInstance<BaseGraph>();
            graphWindow._tmpGraph.hideFlags = HideFlags.HideAndDontSave;
            graphWindow.InitializeGraph(graphWindow._tmpGraph);

            graphWindow.Show();

            return graphWindow;
        }

        protected override void OnDestroy()
        {
            graphView?.Dispose();
            DestroyImmediate(_tmpGraph);
        }

        protected override void InitializeWindow(BaseGraph graph)
        {
            titleContent = new GUIContent("Behaviour Graph");

            if (graphView == null)
            {
                graphView = new BehaviourGraphView(this);
                _toolbarView = new BehaviourToolbarView(graphView);
                graphView.Add(_toolbarView);
            }

            rootView.Add(graphView);
        }
    }
}