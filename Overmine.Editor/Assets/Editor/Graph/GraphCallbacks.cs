using Data;
using GraphProcessor;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace Editor.Graph
{
	public static class GraphCallbacks
	{
		[MenuItem("Assets/Create/Data/Behaviour Graph")]
		public static void CreateGraph()
		{
			var graph = ScriptableObject.CreateInstance<BehaviourGraph>();
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
