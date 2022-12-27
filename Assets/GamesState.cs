using UnityEngine;

public class GamesState : BState
{

    public GamesState(Statemachine owner) : base(owner)
    {

    }
    public override void Enter()
    {
        Time.timeScale = 1;
    }

    public override void Exit()
    {
        Time.timeScale = 0;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _owner.ChangeState(typeof(PauseState));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _owner.ChangeState(typeof(FinalState));
        }
    }
}


