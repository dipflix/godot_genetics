using GeneticsMono.Script.Utils.StateManagers;
using Godot;

namespace GeneticsMono.Script.GameObject.States.AgentStates;

public partial class AgentIdleState : EntityState
{
    public AgentIdleState(StaticBody2D body) : base(body)
    {
    }

    public override void Update(double delta)
    {
        GD.Print(Body.Position);
        Body.Position += new Vector2(0, 0.1f);
    }
}