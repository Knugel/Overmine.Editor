using BehaviorDesigner.Runtime;
using GraphProcessor;
using Thor;

namespace Editor.Graph.Nodes.Constructors
{
    [System.Serializable, NodeMenuItem("Constructors/Status Effect Data")]
    public class StatusEffectDataNode : BaseNode
    {
        [Input("Level"), ShowAsDrawer]
        public SharedInt Level = new SharedInt();
        
        [Input("Duration"), ShowAsDrawer]
        public SharedFloat Duration = new SharedFloat();
        
        [Input("User Data"), ShowAsDrawer]
        public SharedInt UserData = new SharedInt();
        
        [Input("User String"), ShowAsDrawer]
        public SharedString UserString = new SharedString();
        
        [Input("Hint"), ShowAsDrawer]
        public SharedString Hint = new SharedString();
        
        [Input("Sticky"), ShowAsDrawer]
        public SharedBool Sticky = new SharedBool();
        
        [ShowInInspector]
        public bool Blocked;

        [Output("Out")]
        public StatusEffectExt.StatusEffectData Output;

        public override string name => "Status Effect Data";
        
        protected override void Process()
        {
            Output = new StatusEffectExt.StatusEffectData
            {
                level = Level,
                duration = Duration,
                userData = UserData,
                userString = UserString,
                hint = Hint,
                sticky = Sticky,
                blocked = Blocked
            };
        }
    }
}