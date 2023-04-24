using GeneticsMono.Script.Services.State;
using GeneticsMono.Script.Utils;
using Godot;

namespace GeneticsMono.Script;

public partial class Application : NodeSingleton<Application>
{
    private IAppStateService _appStateService;

    public Application()
    {
        _appStateService = IAppStateService.Get;
        
        GD.Print(_appStateService.TotalGenetics);
    }
}