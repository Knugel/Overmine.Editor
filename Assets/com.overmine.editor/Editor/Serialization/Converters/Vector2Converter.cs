using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Editor.Serialization.Converters
{
    public class Vector2Converter : JsonConverter<Vector2>
    {
        public override void WriteJson(JsonWriter writer, Vector2 value, JsonSerializer serializer)
        {
            var obj = new JValue($"({value.x},{value.y})");
            obj.WriteTo(writer);
        }
        
        public override Vector2 ReadJson(JsonReader reader, Type objectType, Vector2 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            value = value.Substring(1).Substring(0, value.Length - 2);
            var split = value.Split(',');
            var x = float.Parse(split[0]);
            var y = float.Parse(split[1]);
            return new Vector2(x, y);
        }

        public override bool CanWrite => true;

        public override bool CanRead => true;
    }
}