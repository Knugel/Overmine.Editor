using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using BehaviorDesigner.Runtime;
using Editor.Export;
using Editor.Graph.Nodes;
using Editor.Graph.Parameters;
using GraphProcessor;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Editor.Graph.Serialization
{
    public static class NodeSerializer
    {
        public static JsonSerializer Serializer;

        static NodeSerializer()
        {
            Serializer = JsonSerializer.CreateDefault();
            Serializer.Converters.Add(new Vector2Converter());
            Serializer.Converters.Add(new Vector3Converter());
            Serializer.Converters.Add(new ColorConverter());
            Serializer.Converters.Add(new SharedVariableConverter());
            Serializer.Converters.Add(new StringEnumConverter());
            Serializer.ContractResolver = new PrefixTypeContractResolver();
            Serializer.Formatting = Formatting.Indented;
        }

        public static string Serialize(BaseGraph graph)
        {
            foreach (var parameter in graph.exposedParameters)
            {
                if (parameter.value is SharedVariable shared)
                {
                    shared.Name = parameter.name;
                    shared.IsShared = true;
                    
                    // TODO: Remove ugly hack for global variables and introduce an actual setting
                    if (shared.Name == "Entities" || shared.Name == "Player")
                        shared.IsGlobal = true;
                }
            }
            
            var processes = graph.nodes.OrderBy(n => n.computeOrder).ToList();
            foreach (var process in processes)
            {
                process.OnProcess();
            }

            var entry = processes.FirstOrDefault(x => x is EntryTaskNode);
            if (entry != null) return SerializeGraph(entry, graph);
            
            Debug.LogWarning($"Graph {AssetDatabase.GetAssetPath(graph)} has no Entry node and will be left empty");
            return null;
        }
        
        private static string SerializeGraph(BaseNode entry, BaseGraph graph)
        {
            var id = 1;
            
            if (entry?.GetOutputNodes()?.FirstOrDefault() is AbstractTaskNode output)
            {
                var root = SerializeNode(output, ref id);
                var variables = SerializeVariables(graph.exposedParameters);
                
                var node = new JObject
                {
                    { "EntryTask", GetEntryTask() },
                    { "RootTask", root },
                    { "Variables", variables }
                };
                
                var sb = new StringBuilder();
                Serializer.Serialize(new StringWriter(sb), node);
                return sb.ToString();
            }
            return null;
        }

        private static JObject SerializeNode(AbstractTaskNode node, ref int id)
        {
            var obj = JObject.FromObject(new
            {
                Type = EvaluateType(node.Type),
                ID = id,
                Name = node.name,
                Instant = node.Instant
            }, Serializer);
            
            var outputs = node.GetOutputNodes()
                .OrderBy(x => x.computeOrder);
            var children = new List<JObject>();

            var inputs = node.GetAllPorts();
            var idxNodes = new List<string>();
            
            foreach (var port in inputs)
            {
                if (!node.IsFieldInput(port.fieldName))
                    continue;
                
                var edges = port.GetEdges()
                    .Where(x => x.outputNode is ParameterNode param && param.parameter is ObjectParameter)
                    .ToList();
                
                if (port.portData.acceptMultipleEdges)
                {
                    var idxList = new List<int>();
                    foreach (var edge in edges)
                    {
                        var param = (ParameterNode) edge.outputNode;
                    
                        var replaced = param.parameter.name.Replace("Index", "").Trim();
                        if (int.TryParse(replaced, out var idx))
                        {
                            idxNodes.Add(port.fieldName);
                            idxList.Add(idx);
                        }
                    }
                    if(idxList.Count > 0)
                        obj.Add(port.fieldInfo.FieldType.Name + port.fieldName, JArray.FromObject(idxList, Serializer));
                }
                else
                {
                    var edge = edges.FirstOrDefault();
                    if (edge == null)
                        continue;

                    var param = (ParameterNode) edge.outputNode;
                    
                    var replaced = param.parameter.name.Replace("Index", "").Trim();
                    if (int.TryParse(replaced, out var idx))
                    {
                        idxNodes.Add(port.fieldName);
                        obj.Add(port.fieldInfo.FieldType.Name + port.fieldName, JToken.FromObject(idx, Serializer));
                    }
                }
            }

            var fields = node
                .GetNodeFields()
                .Where(x => x.GetCustomAttribute<InputAttribute>() != null || x.GetCustomAttribute<ShowInInspector>() != null)
                .Where(x => x.Name != "Instant")
                .Where(x => !idxNodes.Contains(x.Name));
            foreach (var field in fields)
            {
                if(field.FieldType == typeof(ControlFlow))
                    continue;

                var value = field.GetValue(node);
                
                if (value == null && field.FieldType.IsSubclassOf(typeof(SharedVariable)))
                {
                    value = Activator.CreateInstance(field.FieldType);
                }
                
                try
                {
                    var jToken = JToken.FromObject(value, Serializer);
                    obj.Add(field.FieldType.Name + field.Name, jToken);
                }
                catch (Exception e)
                {
                    Debug.Log(value);
                    Debug.LogError(e);
                }
            }
            
            foreach (var output in outputs)
            {
                id++;
                children.Add(SerializeNode(output as AbstractTaskNode, ref id));
            }
            
            if(children.Count > 0)
                obj.Add("Children", JArray.FromObject(children, Serializer));
            
            return obj;
        }

        private static JArray SerializeVariables(IEnumerable<ExposedParameter> parameters)
        {
            var ret = parameters
                .Where(parameter => parameter.value is SharedVariable shared && !shared.Name.StartsWith("Index"))
                .Select(parameter => JObject.FromObject(parameter.value, Serializer))
                .ToList();
            return JArray.FromObject(ret, Serializer);
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

        private static JObject GetEntryTask()
        {
            return new JObject
            {
                { "Type", "BehaviorDesigner.Runtime.Tasks.EntryTask" },
                { "ID", 0 },
                { "Name", "Entry" },
                { "Instant", true }
            };
        }
    }
}