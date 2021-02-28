using Data;
using Editor.Graph.Parameters;
using GraphProcessor;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace Editor.Graph
{
	public static class GraphCallbacks
	{
		private static string[] _requiredParameters = {
			"Self",
			"Owner",
			"Root",
			"Link"
		};
		
		[MenuItem("Assets/Create/Data/Behaviour Graph")]
		public static void CreateGraph()
		{
			var graph = ScriptableObject.CreateInstance<BehaviourGraph>();
			foreach (var param in _requiredParameters)
			{
				graph.AddExposedParameter(param, typeof(EntityParameter));
			}
			
			ProjectWindowUtil.CreateAsset(graph, "Behaviour.asset");
		}
		
		[OnOpenAsset(0)]
		public static bool OnBaseGraphOpened(int instanceID, int line)
		{
			var asset = EditorUtility.InstanceIDToObject(instanceID) as BaseGraph;

			if (asset != null)
			{
				EditorWindow.GetWindow<GraphWindow>().InitializeGraph(asset);
				return true;
			}
			return false;
		}
	}
}
