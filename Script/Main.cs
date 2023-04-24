using GeneticsMono.Script.Services.State;
using Godot;
using Ninject;

namespace GeneticsMono.Script;

public partial class Main : Node
{
    public Main()
    {
        GetX.D.Bind<IAppStateService>().To<AppStateService>().InSingletonScope();
        
        
    }
}