using Unity.VisualScripting;

namespace Game
{
    using HZI.Shared.Interfaces;
    using System.Collections.Generic;

    public class StateNode
    {
        public IState state { get; }                    // the state this node represents
        public HashSet<ITransition> transitions { get; }   // the transitions from this state to other states
        
        public StateNode(IState state)
        {
            this.state = state;
            transitions = new HashSet<ITransition>();       
        }

        public void AddTransition(IState toState, IPredicate predicate)
        {
            transitions.Add(new Transition(toState, predicate));
        }
    }
}