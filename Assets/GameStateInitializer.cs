using System;
using System.Collections.Generic;
using UnityEngine;

public class GameStateInitializer
{

    private Statemachine _owner;
    private SpriteRenderer _spriteRenderer;
    private GameObject _redArea;


    public GameStateInitializer(Statemachine owner, SpriteRenderer spriteRenderer, GameObject redArea)
    {
        _owner = owner;
        _spriteRenderer = spriteRenderer;
        _redArea = redArea;
    }

    public Dictionary<Type, BState> Initialize()
    {
        return new Dictionary<Type, BState>()
        {
            [typeof(GamesState)] = new GamesState(_owner),
            [typeof(FinalState)] = new FinalState(_owner, _spriteRenderer, _redArea),
            [typeof(PauseState)] = new PauseState(_owner)
        };
    }
}


