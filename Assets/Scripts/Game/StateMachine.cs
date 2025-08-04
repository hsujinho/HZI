using System;
using HZI.Game;
using UnityEngine;

namespace Game
{
    using HZI.Shared.Interfaces;
    using System.Collections.Generic;
    
    /// <summary>
    /// 狀態機元件，負責管理當前狀態節點並處理狀態切換事件。
    /// </summary>
    public class StateMachine: MonoBehaviour
    {
        private StateNode _currentStateNode;
        [SerializeField] private EventChannel transitionEventChannel;

        /// <summary>
        /// 啟用時訂閱狀態轉換事件。
        /// </summary>
        private void OnEnable()
        {
            if (transitionEventChannel != null) transitionEventChannel.OnEventRaised += HandleEventRaised;
        }

        /// <summary>
        /// 停用時取消訂閱狀態轉換事件。
        /// </summary>
        private void OnDisable()
        {
            if (transitionEventChannel != null) transitionEventChannel.OnEventRaised -= HandleEventRaised;       
        }
        
        /// <summary>
        /// 狀態轉換事件處理方法，執行事件邏輯。
        /// </summary>
        /// <param name="raisedEvent">被觸發的事件。</param>
        private void HandleEventRaised(IEvent raisedEvent)
        {
            raisedEvent.Execute();
        }
        
        /// <summary>
        /// 切換至指定的狀態節點，並執行離開與進入狀態的相關邏輯。
        /// </summary>
        /// <param name="toStateNode">目標狀態節點。</param>
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