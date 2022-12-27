public abstract class AState
{
    protected StatemachinePlayer _owner;

    protected AState(StatemachinePlayer owner)
    {
        _owner = owner;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}


