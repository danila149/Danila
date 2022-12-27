using UnityEngine;

public class PauseState : BState
{

    public PauseState(Statemachine owner) : base(owner)
    {

    }
    public override void Enter()
    {
        
    }

    public override void Exit()
    {

    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _owner.ChangeState(typeof(GamesState));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _owner.ChangeState(typeof(FinalState));
        }
    }
}



