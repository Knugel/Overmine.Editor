using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(StringNode))]
    public class StringNodeView : BaseNodeView
    {
        public override void Enable()
        {
            var stringNode = nodeTarget as StringNode;

            var textField = new TextField()
            {
                value = stringNode.Output.Value
            };

            stringNode.onProcessed += () => textField.value = stringNode.Output.Value;

            textField.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated stringNode input");
                stringNode.Output = v.newValue;
            });

            controlsContainer.Add(textField);
        }
    }
}