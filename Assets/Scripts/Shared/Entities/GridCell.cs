using Unity.VisualScripting;
using UnityEngine;

namespace HZI.Shared.Entities
{
    public class GridCell: MonoBehaviour
    {
        public Vector2Int position;
        public bool isOccupied = false;
        public GameObject occupant = null; // The object occupying this cell, if any

        public void InitGridCell(Vector2Int pos)
        {
            position = pos;
        }
        public bool SetOccupant(GameObject occupant)
        {
            if (occupant == null)
            {
                Debug.LogError($"Occupant parameter cannot be null!");
                return false;
            }
            else if (isOccupied)
            {
                Debug.LogError($"Occupant parameter is already occupied!");
                return false;
            }
            
            this.occupant = occupant;
            isOccupied = occupant != null;
            return true;
        }
    }
};

