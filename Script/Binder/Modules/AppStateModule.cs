using GeneticsMono.Script.Services.State;
using GeneticsMono.Script.State;
using Godot;
using Ninject.Modules;

namespace GeneticsMono.Script.Binder.Modules;

public class AppStateModule: NinjectModule
{
    private IAppStateService _appStateService;

    public override void Load()
    {
        GD.Print("test");
        _appStateService =new AppStateService();
        
        Bind<IAppStateService>().ToConstant(_appStateService).InSingletonScope();


    }
}