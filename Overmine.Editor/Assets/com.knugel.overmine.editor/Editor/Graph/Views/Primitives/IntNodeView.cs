using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(IntNode))]
    public class IntNodeView : BaseNodeView
    {
        public override void Enable()
        {
            var intNode = nodeTarget as IntNode;

            var intField = new IntegerField()
            {
                value = intNode.Output.Value
            };

            intNode.onProcessed += () => intField.value = intNode.Output.Value;

            intField.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated intNode input");
                intNode.Output = v.newValue;
            });

            controlsContainer.Add(intField);
        }
    }
}