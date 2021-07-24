using System;
using System.Globalization;
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
            var value = reader.Value.ToString();
            value = value.Substring(5, value.Length - 6);
            var split = value.Split(',');
            var r = float.Parse(split[0], CultureInfo.InvariantCulture);
            var g = float.Parse(split[1], CultureInfo.InvariantCulture);
            var b = float.Parse(split[2], CultureInfo.InvariantCulture);
            var a = float.Parse(split[3], CultureInfo.InvariantCulture);
            return new Color(r, g, b, a);
        }
        
        public override bool CanWrite => true;

        public override bool CanRead => true;
    }
}