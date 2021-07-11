using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedDamageType))]
    public class SharedDamageTypeDrawer : SharedPropertyDrawer<SharedDamageType> { }
}