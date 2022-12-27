using TMPro;
using UnityEngine;

public class ShootState : AState
{
    private GameObject _pulka;
    private Transform _FirePointTransform;
    private TMP_Text _text;
    private KeyCode _key;
    public ShootState(StatemachinePlayer owner, GameObject pulka, Transform firePointTransform, TMP_Text text, KeyCode key) : base(owner)
    {
        _pulka = pulka;
        _text = text;
        _FirePointTransform = firePointTransform;
        _key = key;
    }
    public override void Enter()
    {
        _text.text = "ShootState";
    }

    public override void Exit()
    {
        _text.text = "";
    }

    public override void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            Object.Instantiate(_pulka, _FirePointTransform.position, _FirePointTransform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _owner.ChangeState(typeof(RedAreaState));
        }
    }
}

