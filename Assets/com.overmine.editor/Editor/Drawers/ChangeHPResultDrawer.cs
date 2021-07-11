using Thor;
using UnityEditor;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(HealthExt.ChangeHPResult))]
    public class ChangeHPResultDrawer : FlaggedEnumDrawer<ItemData.ItemHint> { }
}