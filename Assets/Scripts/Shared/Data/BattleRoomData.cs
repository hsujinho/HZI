namespace HZI.Shared.Data
{
    using UnityEngine;
    using System;
    
    // this class is used to store the data of a battle room, containing the room data and the unit data...
    // roomData is used to represent the room's size and the faction constraints
    // unitData is used to represent the unit's data. the unit's data is run-time data, grabbing when enter the room

    [System.Serializable]
    public class BattleRoomData
    {
        public RoomData roomData;
        
    }
}