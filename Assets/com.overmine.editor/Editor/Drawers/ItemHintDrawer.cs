using Thor;
using UnityEditor;

namespace Editor.Drawers
{
    [CustomPropertyDrawer(typeof(ItemData.ItemHint))]
    public class ItemHintDrawer : FlaggedEnumDrawer<ItemData.ItemHint> { }
}