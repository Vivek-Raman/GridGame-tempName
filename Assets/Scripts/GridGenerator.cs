using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

    public GameObject CellPrefab;
    public GameObject GridParentPrefab;
    public List<GameObject> Grid;

    private float sideLength;

    void Awake()
    {
        Grid.Clear();
        sideLength = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().LeashLength;
        foreach (GameObject cell in GameObject.FindGameObjectsWithTag("Cell"))
        {
            Destroy(cell);
        }
    }

    void Start()
    {
        // Bottom row
        Grid.Add(Instantiate(CellPrefab, new Vector2(-sideLength, -sideLength), Quaternion.identity, GridParentPrefab.transform));  // 1
        Grid.Add(Instantiate(CellPrefab, new Vector2(0f, -sideLength), Quaternion.identity, GridParentPrefab.transform));           // 2
        Grid.Add(Instantiate(CellPrefab, new Vector2(sideLength, -sideLength), Quaternion.identity, GridParentPrefab.transform));   // 3

        // Middle row
        Grid.Add(Instantiate(CellPrefab, new Vector2(-sideLength, 0f), Quaternion.identity, GridParentPrefab.transform));           // 4
        Grid.Add(Instantiate(CellPrefab, new Vector2(0f, 0f), Quaternion.identity, GridParentPrefab.transform));                    // 5
        Grid.Add(Instantiate(CellPrefab, new Vector2(sideLength, 0f), Quaternion.identity, GridParentPrefab.transform));            // 6

        // Top row
        Grid.Add(Instantiate(CellPrefab, new Vector2(-sideLength, sideLength), Quaternion.identity, GridParentPrefab.transform));   // 7
        Grid.Add(Instantiate(CellPrefab, new Vector2(0f, sideLength), Quaternion.identity, GridParentPrefab.transform));            // 8
        Grid.Add(Instantiate(CellPrefab, new Vector2(sideLength, sideLength), Quaternion.identity, GridParentPrefab.transform));    // 9
    }
}
