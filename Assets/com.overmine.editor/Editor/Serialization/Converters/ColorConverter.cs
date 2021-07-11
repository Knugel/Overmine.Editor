using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Editor.Serialization.Converters
{
    public class ColorConverter : JsonConverter<Color>
    {
        public override void WriteJson(JsonWriter writer, Color value, JsonSerializer serializer)
        {
            var obj = new JValue($"RGBA({value.r},{value.g},{value.b},{value.a})");
            obj.WriteTo(writer);
        }

        public override Color ReadJson(JsonReader reader, Type objectType, Color existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        
        public override bool CanWrite => true;

        public override bool CanRead => false;
    }
}