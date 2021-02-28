using System;
using BehaviorDesigner.Runtime;
using GraphProcessor;

namespace Editor.Graph.Nodes
{
    [System.Serializable, NodeMenuItem("Primitives/Debug")]
    public class DebugNode : AbstractTaskNode
    {
        [Input, ShowAsDrawer]
        public SharedFloat SharedFloat;
        
        [Input, ShowAsDrawer]
        public SharedBool SharedBool;
        
        [Input, ShowAsDrawer]
        public SharedInt SharedInt;
        
        [Input, ShowAsDrawer]
        public SharedString SharedString;
        
        [Input, ShowAsDrawer]
        public SharedVector3 SharedVector3;

        public override Type Type => typeof(DebugNode);
    }
}