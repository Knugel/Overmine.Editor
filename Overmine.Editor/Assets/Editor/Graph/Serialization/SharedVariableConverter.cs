using System;
using System.Reflection;
using BehaviorDesigner.Runtime;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Thor;

namespace Editor.Graph.Serialization
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
            }

            if (value.IsShared)
            {
                obj.Add("IsShared", true);
            }
            else
            {
                obj.Add("Name", null);
            }
            
            if (!string.IsNullOrEmpty(value.Name))
            {
                var replaced = value.Name.Replace("Index", "").Trim();
                
                if (int.TryParse(replaced, out var idx))
                {
                    var field = value.GetType().GetField("mValue", BindingFlags.Instance | BindingFlags.NonPublic);
                    obj.Add(field.FieldType.Name + "mValue", idx);
                    obj.Add("Name", null);

                    obj.Remove("IsShared");
                }
                else
                {
                    obj.Add("Name", value.Name);
                }
            }
            else
            {
                if (!(value is SharedEntity) && !(value is SharedEntityList))
                {
                    var sharedValue = value.GetValue();
                    obj.Add(sharedValue.GetType().Name + "mValue", JToken.FromObject(sharedValue, serializer));
                }
            }
            
            obj.WriteTo(writer);
        }

        public override SharedVariable ReadJson(JsonReader reader, Type objectType, SharedVariable existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanRead => false;

        public override bool CanWrite => true;
    }
}