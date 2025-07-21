namespace HZI.Shared.Data
{
    using UnityEngine;
    using HZI.Shared.Enums;

    // This class is used to store the data that the specific faction can stand on which position in the initial phase.
    [CreateAssetMenu(menuName = "HZI/StandableInitialPosData", fileName = "StandableInitialPosData")]
    public class FactionStandableInitialPosData : ScriptableObject
    {
        public Faction faction;
        public Vector2Int[] standablePositions; // The positions that the faction can stand on in the initial phase
    }
}