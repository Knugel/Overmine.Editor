using BehaviorDesigner.Runtime;
using UnityEditor;

namespace Editor.Drawers.Shared
{
    [CustomPropertyDrawer(typeof(SharedAnimationCurve))]
    public class SharedCurveDrawer : SharedPropertyDrawer<SharedAnimationCurve> { }
}