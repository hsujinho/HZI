namespace Game
{
    using HZI.Shared.Interfaces;
    public class Transition: ITransition
    {
        public IState toState { get; }
        public IPredicate condition { get; }
        
        public Transition(IState toState, IPredicate condition)
        {
            this.toState = toState;
            this.condition = condition;
        }
    }
}