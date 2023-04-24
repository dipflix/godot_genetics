using System;
using System.Collections.Generic;
using GeneticsMono.Script.GameObject.Entities.Base;
using Godot;

namespace GeneticsMono.Script.Utils.StateManagers;

public partial class EntityStateManager<T> where T: Entity
{
    public EntityState CurrentState => _states[_currentState];

    private Enum _currentState { get; set; }

    private Dictionary<Enum, EntityState> _states;

    public EntityStateManager(T entity, Dictionary<Enum, EntityState> states, Enum initialState)
    {
        _states = states;
        ChangeState(initialState);
    }


    internal void AddState(Enum key, EntityState state) => _states.Add(key, state);

    public void ChangeState(Enum key) => _currentState = key;
}