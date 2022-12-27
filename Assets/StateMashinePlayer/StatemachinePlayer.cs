using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatemachinePlayer
{
    private Dictionary<Type, AState> _states;
    private AState _currentState;
    public void SetStateInitializer(PlayerStateInitializer playerStateInitializer)
    {
        _states = playerStateInitializer.Initialize();
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
    public AState GetState() => _currentState;
}
