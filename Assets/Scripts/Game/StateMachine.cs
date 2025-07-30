using System;
using HZI.Game;
using UnityEngine;

namespace Game
{
    using HZI.Shared.Interfaces;
    using System.Collections.Generic;
    
    public class StateMachine: MonoBehaviour
    {
        // private StateNode _currentStateNode;
        // public Dictionary<Type, StateNode> StateNodes;
        // public HashSet<ITransition> AnyTransitions;
        //
        // public void changeState(IState state)
        // {
        //     if(state == _currentStateNode.state)
        //         return;
        //     
        //     var previousState = _currentStateNode.state;
        //     var nextState = StateNodes[state.GetType()].state;
        //     
        //     previousState.OnExit();
        //     nextState.OnEnter();
        //     _currentStateNode = StateNodes[state.GetType()];
        // }
        
        // private IState _currentState;
        private StateNode _currentStateNode;
        [SerializeField] private EventChannel transitionEventChannel;

        private void OnEnable()
        {
            if (transitionEventChannel != null) transitionEventChannel.OnEventRaised += HandleEventRaised;
        }

        private void OnDisable()
        {
            if (transitionEventChannel != null) transitionEventChannel.OnEventRaised -= HandleEventRaised;       
        }
        
        private void HandleEventRaised(IEvent raisedEvent)
        {
            raisedEvent.Execute();
        }

        /// <summary>
        /// Changes the current state of the state machine to the specified state node.
        /// </summary>
        /// <param name="toStateNode">The target state node to transit to.</param>
        public void ChangeState(StateNode toStateNode)
        {
            if (toStateNode == _currentStateNode || toStateNode == null)
                return;
            var previousState = _currentStateNode?.state;
            _currentStateNode = toStateNode;
            previousState?.OnExit();
            _currentStateNode?.state?.OnEnter();
        }
    }
}