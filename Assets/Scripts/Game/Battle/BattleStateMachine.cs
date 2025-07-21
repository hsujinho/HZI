using System.Collections.Generic;
using UnityEngine;
using HZI.Shared.Enums;
using HZI.Shared.Data;
using HZI.Shared.Entities;

// This class manages the state machine for the battle system.
public class BattleStateMachine : MonoBehaviour
// {
//     [SerializeField] private RoomData roomData;
//     
//     public BattleState currentState;
//     public List<Unit> turnOrder;
//     
//     void Start()
//     {
//         ChangeState(BattleState.Init);
//     }
//     
//     private void ChangeState(BattleState newState)
//     {
//         currentState = newState;
//         switch (currentState)
//         {
//             case BattleState.Init:
//                 Init();
//                 break;
//             case BattleState.TurnStart:
//                 // TurnStart();
//                 break;
//             case BattleState.ActionPhase:
//                 // ActionPhase();
//                 break;
//             case BattleState.TurnEnd:
//                 // TurnEnd();
//                 break;
//             // case BattleState.CheckBattleEnd:
//                 // CheckBattleEnd();
//                 // break;
//             case BattleState.BattleEnd:
//                 // BattleEnd();
//                 break;
//         }
//     }
//
//     private void Init()
//     {
//         // Initialize the grid manager
//         GridManager.instance.InitGridManager(roomData.roomSize, 1f);
//         
//         // Initialize the turn order list
//         // get all units in the scene
//         turnOrder = UnitFinder.GetSceneUnits();
//         // sort them by speed: high to low
//         turnOrder.Sort((x, y) => y.unitData.speed.CompareTo(x.unitData.speed));
//         
//         // place units on the grid
//         GridPlacer gridPlacer = FindFirstObjectByType<GridPlacer>();
//         gridPlacer.PlaceUnits(turnOrder, roomData);
//         
//         // set the current state to TurnStart
//         ChangeState(BattleState.TurnStart);
//     }
// }
{
    
}