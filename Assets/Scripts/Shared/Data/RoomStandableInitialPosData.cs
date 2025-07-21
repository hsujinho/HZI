namespace HZI.Shared.Data
{
    using UnityEngine;
    
    // this class is used to store FactionStandableInitialPosData List to represent a specific room's faction constraints
    [CreateAssetMenu(menuName = "HZI/RoomStandableInitialPosData", fileName = "RoomStandableInitialPosData")]
    public class RoomStandableInitialPosData : ScriptableObject
    {
        public FactionStandableInitialPosData[] factionStandableInitialPosDataList; // The list of faction standable initial positions
    }
}

