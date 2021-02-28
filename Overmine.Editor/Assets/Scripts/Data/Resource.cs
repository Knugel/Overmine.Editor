using Thor;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Resource", menuName = "Data/Resource")]
    public class Resource : Identifiable
    {
        public string Name;

        public ResourceData.ResourceType Type;
    }
}