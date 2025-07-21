using System;

namespace Game
{
    using HZI.Shared.Interfaces;
    using System.Collections.Generic;
    
    public class StateMachine
    {
        private StateNode _currentStateNode;
        public Dictionary<Type, StateNode> StateNodes;
        public HashSet<ITransition> AnyTransitions;

        public void changeState(IState state)
        {
            if(state == _currentStateNode.state)
                return;
            
            var previousState = _currentStateNode.state;
            var nextState = StateNodes[state.GetType()].state;
            
            previousState.OnExit();
            nextState.OnEnter();
            _currentStateNode = StateNodes[state.GetType()];
        }
    }
}