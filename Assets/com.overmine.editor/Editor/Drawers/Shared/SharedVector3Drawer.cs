using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedVector3))]
    public class SharedVector3Drawer : SharedPropertyDrawer<SharedVector3> { }
}