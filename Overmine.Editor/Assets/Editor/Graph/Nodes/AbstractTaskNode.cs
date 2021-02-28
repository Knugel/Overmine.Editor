using System;
using GraphProcessor;

namespace Editor.Graph.Nodes
{
    public abstract class AbstractTaskNode : BaseNode
    {
        [Input, Vertical]
        public ControlFlow In;

        [ShowInInspector] 
        public bool Instant = true;

        public abstract Type Type { get; }
    }
}