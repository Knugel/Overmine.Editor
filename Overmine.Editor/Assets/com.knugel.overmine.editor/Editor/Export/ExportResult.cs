using UnityEngine;

namespace Editor.Export
{
    public class ExportResult
    {
        public readonly UnityEngine.Object Source;
        
        public readonly UnityEngine.Object Result;

        public ExportResult(Object source, Object result)
        {
            Source = source;
            Result = result;
        }
    }
}