namespace HZI.Shared.Entities  
{
    using System.Collections.Generic;
    using UnityEngine;
    using HZI.Shared.Data;
    using HZI.Shared.Enums;

    // This class represents a unit in the game.
    public class Unit : MonoBehaviour
    {
        public UnitData unitData;
        public int currentHp;
        public Faction faction;
        public bool isAlive;
        
        void Start()
        {
            currentHp = unitData.maxHp;
        }
    }
};

