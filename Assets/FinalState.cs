using UnityEngine;

public class FinalState : BState
{
    private SpriteRenderer _spriteRenderer;
    private GameObject _redArea;
    Color _color;
    public FinalState(Statemachine owner, SpriteRenderer spriteRenderer, GameObject redArea) : base(owner)
    {
        _spriteRenderer = spriteRenderer;
        _color = _spriteRenderer.color;
        _redArea = redArea;
    }
    public override void Enter()
    {
        Time.timeScale = 0;
    }

    public override void Exit()
    {

    }

    public override void Update()
    {
        _redArea.SetActive(false);
        _spriteRenderer.color = new Color(0,255,0,1);
    }
}


