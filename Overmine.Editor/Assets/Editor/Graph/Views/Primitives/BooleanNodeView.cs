using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(BooleanNode))]
    public class BooleanNodeView : BaseNodeView
    {
        public override void Enable()
        {
            var booleanNode = nodeTarget as BooleanNode;

            var toggleField = new Toggle()
            {
                value = booleanNode.Output.Value
            };

            booleanNode.onProcessed += () => toggleField.value = booleanNode.Output.Value;

            toggleField.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated booleanNode input");
                booleanNode.Output = v.newValue;
            });

            controlsContainer.Add(toggleField);
        }
    }
}