using HZI.Shared.Interfaces;
using UnityEngine;

namespace HZI.Game
{
    /// <summary>
    /// 事件通道 ScriptableObject，用於集中管理遊戲事件的發送與監聽。
    /// </summary>
    [CreateAssetMenu(menuName = "HZI/Game/EventChannel")]
    public class EventChannel: ScriptableObject
    {
        /// <summary>
        /// 事件委派，定義事件處理方法的簽名。
        /// </summary>
        /// <param name="raisedEvent">被觸發的事件，需實作 IEvent 介面。</param>
        public delegate void EventRaised(IEvent raisedEvent);
        
        /// <summary>
        /// 當事件被觸發時呼叫的事件。
        /// 訂閱者可透過此事件接收並處理事件。
        /// </summary>
        public event EventRaised OnEventRaised;
        
        /// <summary>
        /// 觸發事件並執行其相關邏輯。
        /// </summary>
        /// <param name="raisedEvent">要觸發的事件，必須實作 IEvent 介面。</param>
        public void RaiseEvent(IEvent raisedEvent)
        {
            if(raisedEvent == null)
            {
                Debug.LogWarning("Raised event is null.");
                return;
            }
            // 若有訂閱者則呼叫事件。
            OnEventRaised?.Invoke(raisedEvent);
            // 執行事件本身的邏輯。
            raisedEvent.Execute();
        }
    }
}