using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedInt))]
    public class SharedIntDrawer : SharedPropertyDrawer<SharedInt> { }
}