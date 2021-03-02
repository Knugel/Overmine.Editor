using System.Collections.Generic;
using GraphProcessor;

namespace Data
{
    public class BehaviourGraph : BaseGraph
    {
        public bool PreProcess;

        public bool AutoStart = true;

        public bool RestartWhenComplete = true;

        public bool PauseWhenDisabled;

        public bool Interruptable;
        
        public List<UnityEngine.Object> Objects;
    }
}