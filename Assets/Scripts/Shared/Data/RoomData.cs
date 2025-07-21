namespace HZI.Shared.Data
{
    using UnityEngine;
    
    [CreateAssetMenu(menuName = "HZI/RoomData", fileName = "RoomData")]
    public class RoomData : ScriptableObject
    {
        public string roomName;
        public Vector2Int roomSize; // The size of the room in grid cells
        public RoomStandableInitialPosData roomStandableInitialPosData; // The standable initial positions for the room
    }
}

