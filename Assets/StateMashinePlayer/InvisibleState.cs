using TMPro;
using UnityEngine;

public class InvisibleState : AState
{
    private TMP_Text _text;
    private KeyCode _key;
    private SpriteRenderer _spriteRenderer;
    bool _visible = true;
    Color _color;
    public InvisibleState(StatemachinePlayer owner , SpriteRenderer spriteRenderer, TMP_Text text, KeyCode key) : base(owner)
    {
        _spriteRenderer = spriteRenderer;
        _text = text;
        _key = key;
        _color = _spriteRenderer.color;
    }
    public override void Enter()
    {
        _text.text = "InvisibleState";
    }

    public override void Exit()
    {
        _color.a = 1;
        _text.text = "";
        _spriteRenderer.color = _color;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            if (_visible)
            {
                _color.a /= 2;
                _spriteRenderer.color = _color;
                _visible = false;
            }
            else{
                _color.a *= 2;
                _spriteRenderer.color = _color;
                _visible = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _owner.ChangeState(typeof(ShootState));
        }
    }
}