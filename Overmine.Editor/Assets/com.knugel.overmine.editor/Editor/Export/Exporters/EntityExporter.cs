using System.Linq;
using Thor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class EntityExporter : ComponentExporter<Components.Entity>
    {
        public override void OnExport(GameObject root, Components.Entity source, Exporter exporter)
        {
            var entity = root.AddComponent<Entity>();
            entity.SetField("m_data", exporter.Export(source.Data));
            entity.SetField("m_guid", source.Guid);
            entity.SetField("m_constrain", source.Constrain);
            entity.SetField("m_filterable", source.Filterable);
            entity.SetField("m_persistent", source.Persistent);
            entity.SetField("m_inheritTeam", source.InheritTeam);
            entity.SetField("m_initialTags", source.InitialTags.Select(x => (Tag) x).ToList());
            entity.SetField("m_team", source.Team);
            entity.SetField("m_agentTypeID", source.AgentTypeID);
            entity.SetField("m_initPhase", source.InitPhase);
            entity.SetField("m_sortingType", source.SortingType);
            entity.SetField("m_doorBlocker", source.DoorBlocker);
            entity.SetField("m_userData", source.UserData);
            entity.SetField("m_userString", source.UserString);
            entity.SetField("m_popupOffsets", source.PopupOffsets);
        }
    }
}