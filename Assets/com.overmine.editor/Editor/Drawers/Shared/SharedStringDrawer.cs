using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedString))]
    public class SharedStringDrawer : SharedPropertyDrawer<SharedString> { }
}