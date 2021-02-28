using System.IO;
using System.Linq;
using Data;
using Editor.Data;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class ItemExporter : AssetExporter<Item, ItemData>
    {
        protected override Object PrepareExport(string path, Item source, Exporter exporter)
        {
            var itemData = ScriptableObject.CreateInstance<ItemData>();
            AssetDatabase.CreateAsset(itemData, Path.Combine(path, $"{source.name}.asset"));
            return itemData;
        }

        protected override Object OnExport(string path, Item source, ItemData result, Exporter exporter)
        {
            // EntityData fields
            result.SetField("m_guid", source.guid);
            result.SetField("m_icon", exporter.Export(source.Icon));
            result.SetField("m_portrait", exporter.Export(source.Portrait));
            result.SetField("m_displayName", source.DisplayName);
            result.SetField("m_description", source.Description);
            result.SetField("m_flavor", source.Flavor);
            result.SetField("m_rarity", source.Rarity);
            result.SetField("m_showInJournal", source.ShowInJournal);
            result.SetField("m_isDeprecated", source.IsDeprecated);
            
            // Item fields
            result.SetField("m_hint", source.Hint);
            result.SetField("m_slot", source.Slot);
            result.SetField("m_audio", source.Audio);
            result.SetField("m_tags", source.Tags.Select(x => (Tag)x).ToList());
            result.SetField("m_costGroups", source.CostGroups);
            result.SetField("m_maxDropCount", source.MaxDropCount);
            result.SetField("m_isDefault", source.IsDefault);
            result.SetField("m_isDefaultDiscovered", source.IsDefaultDiscovered);
            result.SetField("m_autoUnlock", source.AutoUnlock);
            result.SetField("m_rerollable", source.Rerollable);
            result.SetField("m_allowOnAltar", source.AllowOnAltar);
            result.SetField("m_pickedUpBehavior", exporter.Export(source.PickedUpBehaviour));
            result.SetField("m_secondaryPickedUpBehavior", exporter.Export(source.SecondaryPickedUpBehaviour));
            
            result.SetField("m_isSpecialDrop", source.IsSpecialDrop);
            result.SetField("m_isSpecialDiscovery", source.IsSpecialDiscovery);
            result.SetField("m_comboPiece", exporter.Export(source.ComboPiece));
            result.SetField("m_comboResult", exporter.Export(source.ComboResult));
            
            result.SetField("m_userData", source.UserData);
            result.SetField("m_dropRequirements", source.DropRequirements);
            result.SetField("m_discoverRequirements", source.DiscoverRequirements);
            return null;
        }
    }
}