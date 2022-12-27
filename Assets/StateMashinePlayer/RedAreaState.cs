using TMPro;
using UnityEngine;

public class RedAreaState : AState
{
    private GameObject _redArea;
    private TMP_Text _text;
    private KeyCode _key; 
    public RedAreaState(StatemachinePlayer owner, GameObject redArea, KeyCode key, TMP_Text text) : base(owner)
    {
        _redArea = redArea;
        _key = key; 
        _text = text;
    }
    public override void Enter()
    {
        _text.text = "RedAreaState";
    }

    public override void Exit()
    {
        _text.text = "";
        _redArea.SetActive(false);
    }

    public override void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            if (_redArea.activeSelf)
            {
                _redArea.SetActive(false);
            }
            else
            {
                _redArea.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _owner.ChangeState(typeof(InvisibleState));
        }
    }
}