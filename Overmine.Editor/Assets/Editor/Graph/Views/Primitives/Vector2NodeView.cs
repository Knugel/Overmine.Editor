using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(Vector2Node))]
    public class Vector2NodeView : BaseNodeView
    {
        public override void Enable()
        {
            var vector2Node = nodeTarget as Vector2Node;

            var vector2Field = new Vector2Field()
            {
                value = vector2Node.Output.Value
            };

            vector2Node.onProcessed += () => vector2Field.value = vector2Node.Output.Value;

            vector2Field.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated vector2Node input");
                vector2Node.Output = v.newValue;
            });

            controlsContainer.Add(vector2Field);
        }
    }
}