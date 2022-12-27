using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private GameObject _pulka;
    [SerializeField] private Transform _FirePointTransform;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private KeyCode _key;
    [SerializeField] private GameObject _redArea;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private StatemachinePlayer _stateMachinePlayer;
    private Statemachine _stateMachineGame;
    void Start()
    {
        _stateMachinePlayer = new StatemachinePlayer();
        _stateMachinePlayer.SetStateInitializer(new PlayerStateInitializer(
            _stateMachinePlayer,
            _pulka,
            _FirePointTransform,
            _text,
            _key,
            _redArea,
            _spriteRenderer
            ));
        _stateMachinePlayer.ChangeState(typeof(ShootState));
        _stateMachineGame = new Statemachine();
        _stateMachineGame.SetStateInitializer(new GameStateInitializer(
            _stateMachineGame,
            _spriteRenderer,
            _redArea
            ));
        _stateMachineGame.ChangeState(typeof(GamesState));
    }
    void Update()
    {
        _stateMachinePlayer.UseStateUpdate();
        _stateMachineGame.UseStateUpdate();
    }
}
