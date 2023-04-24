using Godot;

namespace GeneticsMono.Script.Utils.StateManagers;

public abstract class EntityState
{
    public StaticBody2D Body { get; }
    
    protected EntityState(StaticBody2D body) => Body = body;

    public abstract void Update(double delta);
}