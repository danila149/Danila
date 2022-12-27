public abstract class BState
{
    protected Statemachine _owner;

    protected BState(Statemachine owner)
    {
        _owner = owner;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}

