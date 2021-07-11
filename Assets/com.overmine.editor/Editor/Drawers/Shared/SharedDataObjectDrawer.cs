using Thor;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedDataObject))]
    public class SharedDataObjectDrawer : SharedPropertyDrawer<SharedDataObject> { }
}