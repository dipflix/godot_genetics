using Ninject;

namespace GeneticsMono.Script.Services.State;

public interface IAppStateService
{
    static IAppStateService Get = GetX.D.Get<IAppStateService>();
    
    public int TotalGenetics { get; }
}