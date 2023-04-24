using System;
using System.Collections.Generic;
using GeneticsMono.Script.GameObject.Entities;
using GeneticsMono.Script.GameObject.States.AgentStates;
using GeneticsMono.Script.Utils;
using GeneticsMono.Script.Utils.StateManagers;
using Godot;

namespace GeneticsMono.Script.GameObject.States;

public partial class AgentStateManager : EntityStateManager<Agent>
{
    public AgentStateManager(Agent entity) : base(entity,
        new Dictionary<Enum, EntityState>()
        {
            { Test.qwe, new TestState(entity) },
            { Test.wer, new AgentIdleState(entity) },
        },
        Test.wer
    )
    {
   
    }
}

enum Test
{
    qwe,
    wer,
}

class TestState : EntityState
{
    public TestState(StaticBody2D body) : base(body)
    {
    }

    public override void Update(double delta)
    {
        GD.Print(Body.Position);
    }
}