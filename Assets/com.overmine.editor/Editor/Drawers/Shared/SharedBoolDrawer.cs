using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedBool))]
    public class SharedBoolDrawer : SharedPropertyDrawer<SharedBool> { }
}