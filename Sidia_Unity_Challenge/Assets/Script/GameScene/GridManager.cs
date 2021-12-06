using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int altura, largura;
    private float gridSpace = 3f;
    public Vector3 gridOrigin = Vector3.zero;
    public GameObject[] item;
    public GameObject[] collectables;

    public Tile tilePrefab;
    


    void Start()
    {
        GridGenerator();
    }


    void GridGenerator()
    {
        for (int x = 0; x < altura; x++)
            for (int z = 0; z < largura; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpace, 0, z * gridSpace) + gridOrigin;
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
    }

    void PickAndSpawn (Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, item.Length);
        int randomIndexCollect = Random.Range(0, collectables.Length);
        GameObject clone = Instantiate(item[randomIndex], positionToSpawn, rotationToSpawn);
        GameObject clone2 = Instantiate(collectables[randomIndexCollect], positionToSpawn, rotationToSpawn);
    }

    
   
}
