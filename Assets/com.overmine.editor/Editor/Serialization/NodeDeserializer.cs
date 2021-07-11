using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Editor.Serialization.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Overmine.Editor.Graph;
using Thor;
using UnityEngine;

namespace Editor.Serialization
{
    public static class NodeDeserializer
    {
        public static void Deserialize(TaskSerializationData data, BehaviourGraphView view)
        {
            if (string.IsNullOrEmpty(data.JSONSerialization))
                return;
            
            var obj = JObject.Parse(data.JSONSerialization);
            
            var entry = DeserializeNode(obj.GetValue("EntryTask"), data, view);
            var root = DeserializeNode(obj.GetValue("RootTask"), data, view);
            view.Connect(root, entry);
        }

        private static void DeserializeVariables(JToken token, BehaviourGraphView view)
        {
            var array = token as JArray;
            foreach (var entry in array)
            {
                var type = TaskUtility.GetTypeWithinAssembly(entry.Value<string>("Type"));
                var isGlobal = entry.Value<bool>("IsGlobal");
                var name = entry.Value<string>("Name");
                
                view.AddExposedProperty(new ExposedProperty()
                {
                    Name = name,
                    Type = type,
                    IsGlobal = isGlobal
                });
            }
        }

        private static TaskNode DeserializeNode(JToken token, TaskSerializationData data, BehaviourGraphView view)
        {
            var obj = token as JObject;
            
            var type = TaskUtility.GetTypeWithinAssembly(obj.Value<string>("Type"));
            var nData = obj.Value<JObject>("NodeData");
            var position = nData.GetValue("Offset").ToObject<Vector2>(NodeSerializer.Serializer);

            var node = view.CreateNode(type, position);
            node.Data = DeserializeObject(obj, type, data.fieldSerializationData.unityObjects) as Task;

            var children = obj.GetValue("Children");
            if (children is JArray array)
            {
                foreach (var entry in array)
                {
                    var child = DeserializeNode(entry, data, view);
                    view.Connect(child, node);
                }
            }

            return node;
        }

        private static object DeserializeObject(JObject obj, Type type, List<UnityEngine.Object> unityObjects)
        {
            if(type.IsAbstract)
                type = TaskUtility.GetTypeWithinAssembly(obj.Value<string>("Type"));
            var instance = Activator.CreateInstance(type);
            
            foreach (var field in GetSerializedFields(type))
            {
                var fName = field.FieldType.Name + field.Name;
                var jValue = obj.GetValue(fName);
                object value;
                
                if (jValue is JObject jObj)
                {
                    value = DeserializeObject(jObj, field.FieldType, unityObjects);
                    field.SetValue(instance, value);
                }
                else if(jValue != null)
                {
                    if (jValue.Type == JTokenType.Integer && !field.FieldType.IsNumeric() && !field.FieldType.IsEnum)
                    {
                        var idx = jValue.ToObject<int>();
                        value = unityObjects[idx];
                    }
                    else
                    {
                        value = jValue.ToObject(field.FieldType, NodeSerializer.Serializer);
                    }
                    field.SetValue(instance, value);
                }
            }

            return instance;
        }

        private static IEnumerable<FieldInfo> GetSerializedFields(Type type)
        {
            return type
                .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(x => x.IsPublic || x.GetCustomAttribute<SerializeField>() != null);
        }
    }
}