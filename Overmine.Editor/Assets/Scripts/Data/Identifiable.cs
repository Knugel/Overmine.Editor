using Thor;
using UnityEngine;

namespace Data
{
    public class Identifiable : DataObject, ISerializationCallbackReceiver
    {
        public void OnBeforeSerialize()
        {
            if (string.IsNullOrEmpty(m_guid))
                m_guid = GUID.get();
        }

        public void OnAfterDeserialize() { }
    }
}