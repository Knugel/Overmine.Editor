using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(FloatNode))]
    public class FloatNodeView : BaseNodeView
    {
        public override void Enable()
        {
            var floatNode = nodeTarget as FloatNode;

            var floatField = new DoubleField
            {
                value = floatNode.Output.Value
            };

            floatNode.onProcessed += () => floatField.value = floatNode.Output.Value;

            floatField.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated floatNode input");
                floatNode.Output = (float) v.newValue;
            });

            controlsContainer.Add(floatField);
        }
    }
}