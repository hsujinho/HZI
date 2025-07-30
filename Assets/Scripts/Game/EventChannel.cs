using HZI.Shared.Interfaces;
using UnityEngine;

namespace HZI.Game
{
    [CreateAssetMenu(menuName = "HZI/Game/EventChannel")]
    public class EventChannel: ScriptableObject
    {
        public delegate void EventRaised(IEvent raisedEvent);
        
        public event EventRaised OnEventRaised;
        
        public void RaiseEvent(IEvent raisedEvent)
        {
            if(raisedEvent == null)
            {
                // 若事件為 null，則輸出警告訊息。
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