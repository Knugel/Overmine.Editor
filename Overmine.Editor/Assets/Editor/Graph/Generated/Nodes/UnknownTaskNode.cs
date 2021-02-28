/* THIS FILE HAS BEEN GENERATED AND SHOULD NOT BE EDITED MANUALLY! */
/* Generated with UnderMine v1.1.2.9 */

namespace Overmine.Generated
{
    [System.Serializable, GraphProcessor.NodeMenuItem("Unknown Task")]
    public class UnknownTaskNode : Editor.Graph.Nodes.AbstractTaskNode
    {
        public override string name => "Unknown Task";

        public override System.Type Type => typeof(BehaviorDesigner.Runtime.Tasks.UnknownTask);

        [GraphProcessor.ShowInInspector]
        public System.String JSONSerialization;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<System.Int32> fieldNameHash;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<System.Int32> startIndex;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<System.Int32> dataPosition;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<UnityEngine.Object> unityObjects;

        [GraphProcessor.ShowInInspector]
        public System.Collections.Generic.List<System.Byte> byteData;

        [GraphProcessor.Input("Owner")]
        public BehaviorDesigner.Runtime.Behavior owner;

        [GraphProcessor.ShowInInspector]
        public System.Int32 id;

        [GraphProcessor.ShowInInspector]
        public System.String friendlyName;

        [GraphProcessor.ShowInInspector]
        public System.Boolean instant;

    }
}
