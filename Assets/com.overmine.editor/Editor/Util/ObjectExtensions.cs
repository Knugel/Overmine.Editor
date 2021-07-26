using System;
using System.Linq;
using System.Reflection;
using Editor.Serialization;

namespace Editor.Util
{
    public static class ObjectExtensions
    {
        public static T GetSerializedField<T>(this UnityEngine.Object obj, string name)
        {
            var field = GetField(obj.GetType(), name);
            return (T) field.GetValue(obj);
        }

        public static void SetSerializedField<T>(this UnityEngine.Object obj, string name, T value)
        {
            var field = GetField(obj.GetType(), name);
            field.SetValue(obj, value);
        }

        private static FieldInfo GetField(Type type, string name)
        {
            var fields = NodeSerializer.GetSerializedFields(type);
            var field = fields.FirstOrDefault(x => x.Name == name);
            if (field == null)
                throw new MissingFieldException($"Couldn't find serialized field {name} on type {type}");
            return field;
        }
    }
}