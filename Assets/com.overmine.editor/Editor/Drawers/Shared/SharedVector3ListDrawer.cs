using Thor;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedVector3List))]
    public class SharedVector3ListDrawer : SharedPropertyDrawer<SharedVector3List> { }
}