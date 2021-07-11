using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedFloat))]
    public class SharedFloatDrawer : SharedPropertyDrawer<SharedFloat> { }
}