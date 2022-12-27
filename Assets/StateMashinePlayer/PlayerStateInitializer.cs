using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStateInitializer
{

    private StatemachinePlayer _owner;
    private GameObject _pulka;
    private Transform _FirePointTransform;
    private TMP_Text _text;
    private KeyCode _key;
    private GameObject _redArea;
    private SpriteRenderer _spriteRenderer;

    public PlayerStateInitializer(StatemachinePlayer owner, GameObject pulka, Transform firePointTransform, TMP_Text text, KeyCode key, GameObject redArea, SpriteRenderer spriteRenderer)
    {
        _owner = owner;
        _pulka = pulka;
        _FirePointTransform = firePointTransform;
        _text = text;
        _key = key;
        _redArea = redArea;
        _spriteRenderer = spriteRenderer;
    }

    public Dictionary<Type, AState> Initialize()
    {
        return new Dictionary<Type, AState>()
        {
            [typeof(ShootState)] = new ShootState(_owner, _pulka, _FirePointTransform, _text,_key),
            [typeof(RedAreaState)] = new RedAreaState(_owner, _redArea, _key, _text),
            [typeof(InvisibleState)] = new InvisibleState(_owner , _spriteRenderer ,_text, _key )
        };
    }
}


