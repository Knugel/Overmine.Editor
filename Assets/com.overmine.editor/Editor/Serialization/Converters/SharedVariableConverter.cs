using System;
using System.Linq;
using BehaviorDesigner.Runtime;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Editor.Serialization.Converters
{
    public class SharedVariableConverter : JsonConverter<SharedVariable>
    {
        public override void WriteJson(JsonWriter writer, SharedVariable value, JsonSerializer serializer)
        {
            var obj = new JObject
            {
                { "Type", NodeSerializer.EvaluateType(value.GetType()) },
            };

            if (value.IsGlobal)
            {
                obj.Add("IsGlobal", true);
                obj.Add("IsShared", true);
                if (!string.IsNullOrEmpty(value.Name))
                {
                    obj.Add("Name", value.Name);
                }
            }
            else if (value.IsShared)
            {
                obj.Add("IsShared", true);
                if (!string.IsNullOrEmpty(value.Name))
                {
                    obj.Add("Name", value.Name);
                }
            }
            else
            {
                obj.Add("Name", null);
                
                var sharedValue = value.GetValue();
                if (sharedValue != null)
                {
                    var type = GetInnerType(value.GetType()) ?? sharedValue.GetType();

                    if (IsReference(type))
                    {
                        obj.Add(type.Name + "mValue", JToken.FromObject(int.Parse(value.PropertyMapping), serializer));
                    }
                    else
                    {
                        obj.Add(type.Name + "mValue", JToken.FromObject(sharedValue, serializer));
                    }
                }
            }

            obj.WriteTo(writer);
        }

        private static bool IsReference(Type type)
        {
            var obj = typeof(UnityEngine.Object);
            return obj.IsAssignableFrom(type);
        }

        private static Type GetInnerType(Type type)
        {
            if (type == typeof(SharedVariable))
                return null;
            return type.BaseType.IsGenericType ? type.BaseType.GetGenericArguments().First() : null;
        }

        public override SharedVariable ReadJson(JsonReader reader, Type objectType, SharedVariable existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            Debug.Log(reader.Path);
            return null;
        }

        public override bool CanRead => false;

        public override bool CanWrite => true;
    }
}