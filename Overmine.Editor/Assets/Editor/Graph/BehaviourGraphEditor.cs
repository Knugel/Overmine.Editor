using Data;
using UnityEditor;

namespace Editor.Graph
{
    [CustomEditor(typeof(BehaviourGraph))]
    public class BehaviourGraphEditor : UnityEditor.Editor
    {
        private SerializedProperty _preProcess;
        private SerializedProperty _autoStart;
        private SerializedProperty _restartWhenComplete;
        private SerializedProperty _pauseWhenDisabled;
        private SerializedProperty _interruptable;
        
        private SerializedProperty _objects;
        
        private void OnEnable()
        {
            _preProcess = serializedObject.FindProperty("PreProcess");
            _autoStart = serializedObject.FindProperty("AutoStart");
            _restartWhenComplete = serializedObject.FindProperty("RestartWhenComplete");
            _pauseWhenDisabled = serializedObject.FindProperty("PauseWhenDisabled");
            _interruptable = serializedObject.FindProperty("Interruptable");
            
            _objects = serializedObject.FindProperty("Objects");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_preProcess);
            EditorGUILayout.PropertyField(_autoStart);
            EditorGUILayout.PropertyField(_restartWhenComplete);
            EditorGUILayout.PropertyField(_pauseWhenDisabled);
            EditorGUILayout.PropertyField(_interruptable);
            
            EditorGUILayout.PropertyField(_objects);
            serializedObject.ApplyModifiedProperties();
        }
    }
}