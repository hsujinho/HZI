using System.Collections.Generic;
using UnityEngine;
using HZI.Shared.Data;
using HZI.Shared.Entities;
using HZI.Shared.Enums;
public class GridPlacer: MonoBehaviour
{
    public void PlaceUnits(List<Unit> units, RoomData roomData)
    {
        var spawnDict = new Dictionary<Faction, List<Vector2Int>>();
        foreach (FactionStandableInitialPosData factionPos in roomData.roomStandableInitialPosData.factionStandableInitialPosDataList)
        {
            spawnDict[factionPos.faction] = new List<Vector2Int>(factionPos.standablePositions);
        }
        
        foreach (Unit unit in units)
        {
            if(!spawnDict.ContainsKey(unit.faction) || spawnDict[unit.faction].Count == 0)
            {
                Debug.LogError($"No spawn position available for unit {unit.name} of faction {unit.faction}");
                continue;
            }
            
            // randomly select a position from the faction's available positions
            int randomIndex = Random.Range(0, spawnDict[unit.faction].Count);
            Vector2Int spawnPos = spawnDict[unit.faction][randomIndex];
            spawnDict[unit.faction].RemoveAt(randomIndex); // remove the position from the list to avoid duplicates
            
            // Place the unit on the grid
            // get the GridCell by given position
            var tmpGridCell = GridManager.instance.GetGridCell(spawnPos);
            if (tmpGridCell != null)
            {
                PlaceGameObjectOnCell(unit, tmpGridCell);
            }
            else
            {
                Debug.LogError($"Grid cell not found for position {spawnPos}");
            }
        }
    }
    
    public void PlaceGameObjectOnCell(Unit unit, GridCell gridCell)
    {
        if (gridCell.SetOccupant(unit.gameObject))
        {
            unit.transform.position = gridCell.transform.position;
            unit.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError($"Failed to place {unit.name} on cell at {gridCell.position}");
        }
    }
}