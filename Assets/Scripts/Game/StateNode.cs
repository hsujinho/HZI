using Unity.VisualScripting;

namespace Game
{
    using HZI.Shared.Interfaces;
    using System.Collections.Generic;

    public class StateNode
    {
        public IState state { get; } // the state this node represents
        public HashSet<ITransition> transitions { get; } // the transitions from this state to other states

        public StateNode(IState state)
        {
            this.state = state;
            transitions = new HashSet<ITransition>();
        }

        public void AddTransition(IState toState, IPredicate predicate)
        {
            transitions.Add(new Transition(toState, predicate));
        }


        /// <summary>
        /// Retrieves the first valid transition from the current state node.
        /// A transition is considered valid if its condition is either null or evaluates to true.
        /// </summary>
        /// <returns>
        /// The first valid <see cref="ITransition"/> if one exists; otherwise, null.
        /// </returns>
        public ITransition GetValidTransition()
        {
            foreach (var transition in transitions)
            {
                if (transition.condition == null || transition.condition.Evaluate())
                {
                    return transition;
                }
            }
        
            return null; 
        }
    }
}