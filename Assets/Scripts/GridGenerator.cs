
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

    public GameObject CellPrefab1, CellPrefab2, CellPrefab3, CellPrefab4, CellPrefab5, CellPrefab6, CellPrefab7, CellPrefab8, CellPrefab9;
    public GameObject GridParentPrefab;

    private float sideLength;

    void Awake()
    {
        sideLength = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().LeashLength;
        foreach (GameObject cell in GameObject.FindGameObjectsWithTag("Cell"))
        {
            Destroy(cell);
        }
    }

    void Start()
    {
        // Bottom row
        Instantiate(CellPrefab1, new Vector2(-sideLength, -sideLength), Quaternion.identity, GridParentPrefab.transform);   // 1
        Instantiate(CellPrefab2, new Vector2(0f, -sideLength), Quaternion.identity, GridParentPrefab.transform);            // 2
        Instantiate(CellPrefab3, new Vector2(sideLength, -sideLength), Quaternion.identity, GridParentPrefab.transform);    // 3

        // Middle row
        Instantiate(CellPrefab4, new Vector2(-sideLength, 0f), Quaternion.identity, GridParentPrefab.transform);            // 4
        Instantiate(CellPrefab5, new Vector2(0f, 0f), Quaternion.identity, GridParentPrefab.transform);                     // 5
        Instantiate(CellPrefab6, new Vector2(sideLength, 0f), Quaternion.identity, GridParentPrefab.transform);             // 6

        // Top row
        Instantiate(CellPrefab7, new Vector2(-sideLength, sideLength), Quaternion.identity, GridParentPrefab.transform);    // 7
        Instantiate(CellPrefab8, new Vector2(0f, sideLength), Quaternion.identity, GridParentPrefab.transform);             // 8
        Instantiate(CellPrefab9, new Vector2(sideLength, sideLength), Quaternion.identity, GridParentPrefab.transform);     // 9
    }
}
