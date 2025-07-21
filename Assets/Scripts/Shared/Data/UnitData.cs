namespace HZI.Shared.Data
{
    using UnityEngine;
    [CreateAssetMenu(menuName = "HZI/UnitData", fileName = "UnitData")]
    public class UnitData : ScriptableObject
    {
        public string unitName;
        public int maxHp;
        public int attack;
        public int defense;
        public int speed;
        // Add any other unit-related data here
    }
}

