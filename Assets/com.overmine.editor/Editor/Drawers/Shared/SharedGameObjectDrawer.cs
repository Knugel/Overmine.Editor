using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedGameObject))]
    public class SharedGameObjectDrawer : SharedPropertyDrawer<SharedGameObject> { }
}