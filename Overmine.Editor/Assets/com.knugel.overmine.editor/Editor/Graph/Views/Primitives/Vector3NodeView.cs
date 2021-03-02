using Editor.Graph.Nodes.Primitives;
using GraphProcessor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Editor.Graph.Views.Primitives
{
    [NodeCustomEditor(typeof(Vector3Node))]
    public class Vector3NodeView : BaseNodeView
    {
        public override void Enable()
        {
            var vector3Node = nodeTarget as Vector3Node;

            var vector3Field = new Vector3Field()
            {
                value = vector3Node.Output.Value
            };

            vector3Node.onProcessed += () => vector3Field.value = vector3Node.Output.Value;

            vector3Field.RegisterValueChangedCallback((v) => {
                owner.RegisterCompleteObjectUndo("Updated vector3Node input");
                vector3Node.Output = v.newValue;
            });

            controlsContainer.Add(vector3Field);
        }
    }
}