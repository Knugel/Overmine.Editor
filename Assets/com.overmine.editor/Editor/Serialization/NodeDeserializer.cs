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

            var entryTask = obj.GetValue("EntryTask");
            var rootTask = obj.GetValue("RootTask");

            if (entryTask == null || rootTask == null || !entryTask.HasValues || !rootTask.HasValues)
            {
                Debug.LogWarning("Couldn't deserialize behavior tree because either the entry or root task was empty!");
                return;
            }

            var entry = DeserializeNode(entryTask, data, view);
            var root = DeserializeNode(rootTask, data, view);
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
                        
            var name = obj.Value<string>("Name");
            var id = obj.Value<int>("ID");
            var instant = obj.Value<bool>("Instant");

            node.title = name;
            
            node.Data = DeserializeObject(obj, type, view, data.fieldSerializationData.unityObjects, node) as Task;
            node.Data.FriendlyName = name;
            node.Data.IsInstant = instant;
            node.Data.ID = id;

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

        private static object DeserializeObject(JObject obj, Type type, BehaviourGraphView view, List<UnityEngine.Object> unityObjects, TaskNode node)
        {
            try
            {
                if (type.IsAbstract)
                    type = TaskUtility.GetTypeWithinAssembly(obj.Value<string>("Type"));
                var instance = NodeSerializer.CreateTypeInstance(type);

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
                        value = DeserializeObject(jObj, field.FieldType, view, unityObjects, node);
                        field.SetValue(instance, value);
                    }
                    else if (jValue != null)
                    {
                        if (jValue.Type == JTokenType.Integer && !field.FieldType.IsNumeric() &&
                            !field.FieldType.IsEnum)
                        {
                            var idx = jValue.ToObject<int>();
                            
                            if (NodeSerializer.IsTaskReference(field.FieldType))
                            {
                                value = view.nodes.ToList().Cast<TaskNode>().FirstOrDefault(x => x.Data.ID == idx)?.Data;
                            }
                            else
                            {
                                if (idx >= unityObjects.Count)
                                    value = null;
                                else
                                    value = unityObjects[idx];
                            }
                        }
                        else if (jValue.Type == JTokenType.Array
                                 && ((JArray) jValue).Any()
                                 && ((JArray) jValue).All(x => x.Type == JTokenType.Integer)
                                 && !field.FieldType.IsNumeric()
                                 && !field.FieldType.IsEnum)
                        {
                            var jArray = jValue as JArray;
                            var array = Array.CreateInstance(field.FieldType.GetElementType(), jArray.Count);
                            for (var i = 0; i < jArray.Count; i++)
                            {
                                var idx = jArray[i].ToObject<int>();
                                if (NodeSerializer.IsTaskReference(field.FieldType))
                                {
                                    var reference = view.nodes.ToList().Cast<TaskNode>().FirstOrDefault(x => x.Data.ID == idx);
                                    array.SetValue(reference.Data, i);
                                }
                                else
                                {
                                    var entry = idx >= unityObjects.Count ? null : unityObjects[idx];
                                    array.SetValue(entry, i);
                                }
                            }

                            value = array;
                        }
                        else
                        {
                            value = jValue.ToObject(field.FieldType, NodeSerializer.Serializer);
                        }

                        if (value != null && !field.FieldType.IsInstanceOfType(value))
                        {
                            var fallback = field.FieldType.IsValueType ? Activator.CreateInstance(field.FieldType) : null;
                            Debug.LogError($"Can't assign value {value} to field {field.Name} of type {field.FieldType.FullName}. Will be substituted with a default of {fallback ?? "null"}");
                            value = fallback;
                        }
                        field.SetValue(instance, value);
                    }
                }

                return instance;
            }
            catch (Exception e)
            {
                Debug.LogError($"Error while trying to deserialize object. Node: '{node.title}', JSON: {obj}, Type: {type.FullName}");
                Debug.LogError(e);
                return null;
            }
        }
    }
}