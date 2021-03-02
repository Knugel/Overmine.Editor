using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using Thor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(DamageTypeNode))]
    public class DamageTypeNodeView : BaseNodeView
    {
        public override void Enable()
        {
            var damageTypeNode = nodeTarget as DamageTypeNode;

            var enumField = new EnumField(HealthExt.DamageType.Physical)
            {
                value = damageTypeNode.Output.Value
            };

            damageTypeNode.onProcessed += () => enumField.value = damageTypeNode.Output.Value;

            enumField.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated booleanNode input");
                damageTypeNode.Output = (HealthExt.DamageType) v.newValue;
            });

            controlsContainer.Add(enumField);
        }
    }
}