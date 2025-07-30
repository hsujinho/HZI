using HZI.Shared.Interfaces;
using UnityEngine.Events;

namespace Game
{
    [System.Serializable]
    public class StateTransitionEvent: UnityEvent, IEvent
    {
        private StateNode _stateNode;
        private StateMachine _stateMachine;
        
        public StateTransitionEvent(StateNode stateNode, StateMachine stateMachine)
        {
            _stateNode = stateNode;
            _stateMachine = stateMachine;
        }

        public void Execute()
        {
            var transition = _stateNode.GetValidTransition();
            if (transition != null)
            {
                _stateMachine.ChangeState(_stateNode);
            }
        }
    }
}