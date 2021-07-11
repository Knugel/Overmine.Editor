using System;

namespace Overmine.Editor.Graph
{
    [Serializable]
    public class ExposedProperty
    {
        public string Name;

        public Type Type;

        public bool IsGlobal;
    }
}