using System.Collections.Generic;
using System.Linq;
using Components;
using Thor;
using UnityEngine;

namespace Editor.Export.Exporters
{
    public class StatusEffectExporter : ComponentExporter<StatusEffect>
    {
        public override void OnExport(GameObject root, StatusEffect source, Exporter exporter)
        {
            var statusEffect = root.AddComponent<StatusEffectExt>();
            statusEffect.SetField("m_loadOrder", source.LoadOrder);
            statusEffect.SetField("m_defaultDuration", source.DefaultDuration);
            statusEffect.SetField("m_stackPolicy", source.StackPolicy);
            statusEffect.SetField("m_position", source.Position);
            statusEffect.SetField("m_showInUI", source.ShowInUI);
            statusEffect.SetField("m_save", source.Save);
            statusEffect.SetField("m_saveUserData", source.SaveUserData);
            statusEffect.SetField("m_userDataFormat", source.UserDataFormat);
            statusEffect.SetField("m_levelFormat", source.LevelFormat);

            var behaviours = source.Behaviours
                .Select(behaviour => exporter.Export(behaviour) as ExtendedExternalBehaviorTree)
                .ToList();

            statusEffect.SetField("m_behaviors", behaviours);
        }
    }
}