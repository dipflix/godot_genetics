using GeneticsMono.Script.GameObject.Entities.Base;
using GeneticsMono.Script.GameObject.States;
using GeneticsMono.Script.Utils;
using GeneticsMono.Script.Utils.StateManagers;

namespace GeneticsMono.Script.GameObject.Entities;

public partial class Agent : Entity
{
    private AgentStateManager _stateManager;


    public Agent()
    {
        _stateManager = new AgentStateManager(this);
        
    }

    public override void _Process(double delta)
    {
        _stateManager.CurrentState.Update(delta);
    }
}