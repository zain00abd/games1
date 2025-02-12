using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    
    public Tile groundTile;
    public GameObject bunkerPrefab;
    public GameObject outpostPrefab;

    void Start()
    {
        GenerateTerrain();
        PlaceStructures();
    }

    void GenerateTerrain()
    {
        int[,] mapLayout = new int[,]
        {
            {0, 0, 1, 1, 0, 0},
            {0, 1, 1, 1, 1, 0},
            {1, 1, 0, 0, 1, 1},
            {0, 1, 1, 1, 1, 0},
            {0, 0, 1, 1, 0, 0}
        };

        for (int x = 0; x < mapLayout.GetLength(0); x++)
        {
            for (int y = 0; y < mapLayout.GetLength(1); y++)
            {
                if (mapLayout[x, y] == 1)
                {
                    
                }
            }
        }
    }

    void PlaceStructures()
    {
        Instantiate(bunkerPrefab, new Vector3(1, 3, 0), Quaternion.identity);
        Instantiate(outpostPrefab, new Vector3(4, 3, 0), Quaternion.identity);
    }
}
