namespace HZI.Shared.Interfaces
{
    public interface ITransition
    {
        IState toState { get; }
        IPredicate condition { get; }
    }
}