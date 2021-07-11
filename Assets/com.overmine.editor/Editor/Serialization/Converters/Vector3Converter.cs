using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Editor.Serialization.Converters
{
    public class Vector3Converter: JsonConverter<Vector3>
    {
        public override void WriteJson(JsonWriter writer, Vector3 value, JsonSerializer serializer)
        {
            var obj = new JValue($"({value.x},{value.y},{value.z})");
            obj.WriteTo(writer);
        }
        
        public override Vector3 ReadJson(JsonReader reader, Type objectType, Vector3 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            value = value.Substring(1).Substring(0, value.Length - 2);
            var split = value.Split(',');
            var x = float.Parse(split[0]);
            var y = float.Parse(split[1]);
            var z = float.Parse(split[2]);
            return new Vector3(x, y,z);
        }

        public override bool CanWrite => true;

        public override bool CanRead => true;
    }
}