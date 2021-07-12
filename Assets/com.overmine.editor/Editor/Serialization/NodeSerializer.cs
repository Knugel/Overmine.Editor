using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Editor.Serialization.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Overmine.API.Assets;
using UnityEditor;
using UnityEngine;

namespace Editor.Serialization
{
    public static class NodeSerializer
    {
        public static JsonSerializer Serializer;

        static NodeSerializer()
        {
            Serializer = JsonSerializer.CreateDefault();
            Serializer.Formatting = Formatting.Indented;
            Serializer.NullValueHandling = NullValueHandling.Ignore;
            Serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            
            Serializer.Converters.Add(new Vector2Converter());
            Serializer.Converters.Add(new Vector3Converter());
            Serializer.Converters.Add(new ColorConverter());
            Serializer.Converters.Add(new SharedVariableConverter());
            Serializer.Converters.Add(new StringEnumConverter());
            
            Serializer.ContractResolver = new PrefixTypeContractResolver();
        }

        public static TaskSerializationData Serialize(BehaviourGraph graph)
        {
            var data = new TaskSerializationData();
            
            var entry = graph.NodesData.FirstOrDefault(x => x.Type == typeof(EntryTask));
            if (entry == null)
            {
                Debug.LogWarning($"Graph {AssetDatabase.GetAssetPath(graph)} has no Entry node and will be left empty");
                return data;
            }

            var nodes = graph.GetLinked(entry);
            var root = nodes.FirstOrDefault();

            var id = 0;
            var objects = new List<UnityEngine.Object>();
            
            var node = new JObject
            {
                { "EntryTask", SerializeNode(graph, entry, objects, ref id, false) },
                { "RootTask", SerializeNode(graph, root, objects, ref id) },
                { "Variables", SerializeVariables(graph) }
            };

            var sb = new StringBuilder();
            Serializer.Serialize(new StringWriter(sb), node);

            data.JSONSerialization = sb.ToString();
            data.Version = "1.5.7";
            data.fieldSerializationData = new FieldSerializationData { unityObjects = objects };

            return data;
        }

        private static JToken SerializeNode(BehaviourGraph graph, NodeData node, List<UnityEngine.Object> objects, ref int id, bool withChildren = true)
        {
            if (node == null)
                return null;
            
            var obj = new JObject();
            obj.Add("Type", JToken.FromObject(EvaluateType(node.Type), Serializer));
            obj.Add("ID", JToken.FromObject(id++, Serializer));
            obj.Add("Name", JToken.FromObject(ObjectNames.NicifyVariableName(node.Type.Name), Serializer));
            obj.Add("Instant", JToken.FromObject(node.Data.IsInstant, Serializer));
            obj.Add("NodeData", new JObject
            {
                ["Offset"] = JToken.FromObject(node.Position, Serializer)
            });

            foreach (var field in GetSerializedFields(node.Type))
            {
                try
                {
                    var value = field.GetValue(node.Data);
                    if (value is SharedVariable shared)
                    {
                        var variable = graph.Variables.FirstOrDefault(x => x.Name == shared.Name);
                        if (variable != null)
                            shared.IsGlobal = variable.IsGlobal;
                        
                        var sValue = shared.GetValue();
                        if (sValue is UnityEngine.Object sObject)
                        {
                            var idx = objects.FindIndex(x => ReferenceEquals(x, sObject));
                            if (idx == -1)
                            {
                                objects.Add(sObject);
                                idx = objects.FindIndex(x => ReferenceEquals(x, sObject));
                            }
                            shared.PropertyMapping = idx.ToString();
                        }
                    } 
                    else if (value is UnityEngine.Object sObject)
                    {
                        var idx = objects.FindIndex(x => ReferenceEquals(x, sObject));
                        if (idx == -1)
                        {
                            objects.Add(sObject);
                            idx = objects.FindIndex(x => ReferenceEquals(x, sObject));
                        }
                        obj.Add(field.FieldType.Name + field.Name, JToken.FromObject(idx, Serializer));
                        continue;
                    }

                    var name = field.FieldType.Name + field.Name;
                    if (value != null && !obj.ContainsKey(name))
                        obj.Add(name, JToken.FromObject(value, Serializer));
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            }

            if (!withChildren)
                return obj;
            
            var children = graph.GetLinked(node).ToList();
            if (children.Count > 0)
            {
                var array = new JArray();
                foreach (var child in children)
                {
                    array.Add(SerializeNode(graph, child, objects, ref id));
                }
                obj.Add("Children", array);
            }
            
            return obj;
        }
        
        private static JToken SerializeVariables(BehaviourGraph graph)
        {
            var ret = new JArray();
            foreach (var variable in graph.Variables)
            {
                if(variable.IsGlobal)
                    continue;
                
                var instance = Activator.CreateInstance(variable.Type) as SharedVariable;
                instance.Name = variable.Name;
                instance.IsShared = true;
                ret.Add(JToken.FromObject(instance, Serializer));
            }
            return ret;
        }

        // From: https://www.codeproject.com/Questions/337574/Given-a-generic-type-how-do-I-get-the-generic-type
        public static string EvaluateType(Type type)
        {
            StringBuilder retType = new StringBuilder();

            if (type.IsGenericType)
            {
                string[] parentType = type.FullName.Split('`');
                // We will build the type here.
                Type[] arguments = type.GetGenericArguments();

                StringBuilder argList = new StringBuilder();
                foreach (Type t in arguments)
                {
                    // Let's make sure we get the argument list.
                    string arg = EvaluateType(t);
                    if (argList.Length > 0)
                    {
                        argList.AppendFormat(", {0}", arg);
                    }
                    else
                    {
                        argList.Append(arg);
                    }
                }

                if (argList.Length > 0)
                {
                    retType.AppendFormat("{0}<{1}>", parentType[0], argList.ToString());
                }
            }
            else
            {
                return type.ToString().Replace("+", ".");
            }

            return retType.ToString().Replace("+", ".");
        }
        
        public static IEnumerable<FieldInfo> GetSerializedFields(Type type)
        {
            var ret = new List<FieldInfo>();
            var toCheck = type;
            
            do
            {
                ret.AddRange(toCheck
                    .GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                    .Where(x => x.IsPublic || x.GetCustomAttribute<SerializeField>() != null));
                toCheck = toCheck.BaseType;
            } while (toCheck != typeof(UnityEngine.Object) && toCheck != null);

            return ret.Where(IsSerializedField).Distinct(new FieldInfoComparer());
        }

        private static bool IsSerializedField(FieldInfo info)
        {
            if (!typeof(Task).IsAssignableFrom(info.DeclaringType))
                return true;
            return info.Name != "id" && info.Name != "instant" && info.Name != "friendlyName";
        }

        class FieldInfoComparer : IEqualityComparer<FieldInfo>
        {
            public bool Equals(FieldInfo x, FieldInfo y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.FieldType.Equals(y.FieldType) && x.Name.Equals(y.Name);
            }

            public int GetHashCode(FieldInfo obj)
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 31 + obj.FieldType.GetHashCode();
                    hash = hash * 31 + obj.Name.GetHashCode();
                    return hash;
                }
            }
        }
    }
}