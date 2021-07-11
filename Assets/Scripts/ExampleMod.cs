using System.Linq;
using System.Reflection;
using Overmine.API;
using Overmine.API.Events;
using Overmine.API.Extensions;
using Thor;
using TMPro;
using UnityEngine;

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
        ev.Instance.RegisterAll(Resources);
    }
}
