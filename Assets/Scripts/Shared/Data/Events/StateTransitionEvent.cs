using HZI.Shared.Interfaces;
using UnityEngine.Events;
using Game;

namespace HZI.Shared.Data.Events
{
    /// <summary>
    /// 狀態轉換事件，繼承自 UnityEvent 並實作 IEvent 介面。
    /// 用於在狀態機中觸發狀態節點的轉換。
    /// </summary>
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

        /// <summary>
        /// 執行狀態轉換邏輯，若有有效轉換則切換狀態。
        /// </summary>
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