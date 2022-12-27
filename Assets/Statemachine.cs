using System;
using System.Collections;
using System.Collections.Generic;

public class Statemachine
{
    private Dictionary<Type, BState> _states;
    private BState _currentState;
    public void SetStateInitializer(GameStateInitializer gameStateInitializer)
    {
        _states = gameStateInitializer.Initialize();
    }
    public void ChangeState(Type stateType)
    {
        _currentState?.Exit();
        _currentState = _states[stateType];
        _currentState?.Enter();
    }
    public void UseStateUpdate()
    {
        _currentState.Update();
    }
    public BState GetState() => _currentState;
}

