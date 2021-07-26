using Overmine.API;
using Overmine.API.Events;
using Overmine.API.Extensions;

public class ExampleMod : Mod
{
    public static ExampleMod Instance { get; private set;  }
    
    public ExampleMod(ModResources resources) : base(resources)
    {
        Instance = this;
        GameEvents.Register<SetupEvent.Post>(OnSetup);
    }
    
    private void OnSetup(SetupEvent.Post ev)
    {
        Resources.ResolveReferences();
        ev.Instance.RegisterAll(Resources);
    }
}
