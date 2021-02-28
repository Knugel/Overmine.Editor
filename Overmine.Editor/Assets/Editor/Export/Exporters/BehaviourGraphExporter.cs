using System.IO;
using System.Linq;
using BehaviorDesigner.Runtime;
using Data;
using Editor.Graph.Serialization;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class BehaviourGraphExporter : AssetExporter<BehaviourGraph, ExtendedExternalBehaviorTree>
    {
        protected override Object PrepareExport(string path, BehaviourGraph source, Exporter exporter)
        {
            var behaviourTree = ScriptableObject.CreateInstance<ExtendedExternalBehaviorTree>();
            AssetDatabase.CreateAsset(behaviourTree, Path.Combine(path, $"{source.name}.asset"));
            return behaviourTree;
        }

        protected override Object OnExport(string path, BehaviourGraph source, ExtendedExternalBehaviorTree result, Exporter exporter)
        {
            result.SetField("m_preProcess", source.PreProcess);
            result.SetField("m_autoStart", source.AutoStart);
            result.SetField("m_restartWhenComplete", source.RestartWhenComplete);
            result.SetField("m_pauseWhenDisabled", source.PauseWhenDisabled);
            result.SetField("m_interruptable", source.Interruptable);

            var objects = source.Objects
                .Select(exporter.Export)
                .Cast<GameObject>()
                .Select(x => x.GetComponent<Entity>())
                .Cast<Object>()
                .ToList();

            result.BehaviorSource = new BehaviorSource
            {
                behaviorName = source.name,
                TaskData = new TaskSerializationData
                {
                    JSONSerialization = NodeSerializer.Serialize(source),
                    Version = "1.6.5",
                    fieldSerializationData = new FieldSerializationData
                    {
                        unityObjects = objects
                    }
                }
            };
            
            return null;
        }
    }
}