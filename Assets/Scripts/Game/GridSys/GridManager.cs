using UnityEngine;
using HZI.Shared.Entities;

public class GridManager : MonoBehaviour
{
    public static GridManager instance { get; private set; }

    [SerializeField] private Grid grid;
    [SerializeField] private GridCell gridCellPrefab;
    
    public Vector2Int gridSize;
    public float cellSize = 1f;
    
    public GridCell[,] GridCells;
    
    // Create a singleton instance of the GridManager
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Initialize the grid manager with the given size and cell size, and create the grid cells with assigning the position
    public void InitGridManager(Vector2Int inputGridSize, float inputCellSize)
    {
        this.gridSize = inputGridSize;
        this.cellSize = inputCellSize;
        // Init the GridCells with setting pos
        GridCells = new GridCell[inputGridSize.x, inputGridSize.y];
        for (int x = 0; x < inputGridSize.x; x++)
        {
            for (int y = 0; y < inputGridSize.y; y++)
            {
                // create a new GridCell component and assign to the GridCells array
                GridCell gridCell = Instantiate(gridCellPrefab, new Vector3(x * inputCellSize, 0, y * inputCellSize), Quaternion.identity, this.transform);
                gridCell.InitGridCell(new Vector2Int(x, y));
                GridCells[x, y] = gridCell;
                gridCell.gameObject.name = $"GridCell_{x}_{y}";
            }
        }
    }
    
    // get the GridCell by given position
    public GridCell GetGridCell(Vector2Int pos)
    {
        // Check if the position is within the bounds of the grid
        if (pos.x < 0 || pos.x >= gridSize.x || pos.y < 0 || pos.y >= gridSize.y)
        {
            Debug.LogError($"Position out of bounds: (poa: {pos}, gridSize: {gridSize})");
            return null;
        }
        
        return GridCells[pos.x, pos.y];
    }
}
