using Thor;
using UnityEditor;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(HealthExt.DamageType))]
    public class DamageTypeDrawer : SignedEnumDrawer<HealthExt.DamageType> { }
}