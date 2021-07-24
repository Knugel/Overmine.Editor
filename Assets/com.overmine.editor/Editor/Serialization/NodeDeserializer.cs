using System;
using System.Collections.Generic;
using System.Linq;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
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
            DeserializeVariables(obj.GetValue("Variables"), view);
            
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
            node.Data = DeserializeObject(obj, type, view, data.fieldSerializationData.unityObjects) as Task;
            
            var name = obj.Value<string>("Name");
            var id = obj.Value<int>("ID");
            var instant = obj.Value<bool>("Instant");

            node.Data.FriendlyName = name;
            node.Data.IsInstant = instant;
            node.Data.ID = id;

            node.title = node.Data.FriendlyName;

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

        private static object DeserializeObject(JObject obj, Type type, BehaviourGraphView view, List<UnityEngine.Object> unityObjects)
        {
            if(type.IsAbstract)
                type = TaskUtility.GetTypeWithinAssembly(obj.Value<string>("Type"));
            var instance = Activator.CreateInstance(type);
            
            foreach (var field in NodeSerializer.GetSerializedFields(type))
            {
                var fName = field.FieldType.Name + field.Name;
                if (typeof(SharedVariable).IsAssignableFrom(type) && field.Name != "mValue")
                {
                    fName = field.Name.Substring(1);
                    fName = char.ToUpper(fName[0]) + fName.Substring(1);
                }
                
                var jValue = obj.GetValue(fName);
                object value;
                
                if (jValue is JObject jObj)
                {
                    value = DeserializeObject(jObj, field.FieldType, view, unityObjects);
                    field.SetValue(instance, value);
                }
                else if(jValue != null)
                {
                    if (jValue.Type == JTokenType.Integer && !field.FieldType.IsNumeric() && !field.FieldType.IsEnum)
                    {
                        var idx = jValue.ToObject<int>();
                        if (idx >= unityObjects.Count)
                            value = null;
                        else
                            value = unityObjects[idx];
                    }
                    else if(jValue.Type == JTokenType.Array 
                            && ((JArray)jValue).All(x => x.Type == JTokenType.Integer) 
                            && !field.FieldType.IsNumeric() 
                            && !field.FieldType.IsEnum)
                    {
                        var jArray = jValue as JArray;
                        var array = Array.CreateInstance(field.FieldType.GetElementType(), jArray.Count);
                        for(var i = 0; i < jArray.Count; i++)
                        {
                            var idx = jArray[i].ToObject<int>();
                            var node = view.nodes.ToList().Cast<TaskNode>().FirstOrDefault(x => x.Data.ID == idx);
                            array.SetValue(node.Data, i);
                        }
                        value = array;
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
    }
}