using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Editor.Graph.Serialization
{
    public class PrefixTypeContractResolver : DefaultContractResolver
    {
        private static readonly string[] Excluded = {
            "Type",
            "ID",
            "Name",
            "Instant",
        };
        
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            var properties = base.CreateProperties(type, memberSerialization);
            foreach (var property in properties)
            {
                if(Excluded.Contains(property.PropertyName))
                    continue;
                
                property.PropertyName = property.PropertyType.Name + property.PropertyName;
            }
            return properties;
        }
    }
}