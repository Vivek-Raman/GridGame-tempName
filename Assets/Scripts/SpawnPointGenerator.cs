
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointGenerator : MonoBehaviour
{
    public List<Ray2D> rays = new List<Ray2D>();
    public float DistanceOfSpawnPoints = 4f;
    public bool ClearAllSpawnPoints = true;
    
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject pointsParent;
    
    void Start()
    {
        if (ClearAllSpawnPoints)
        {
            foreach (GameObject spawn in GameObject.FindGameObjectsWithTag("Spawnpoint"))
            {
                Destroy(spawn);
            }
        }
        FormCircleSpawnPoints(DistanceOfSpawnPoints);
    }

    void FormCircleSpawnPoints(float _distance)
    {
        // create rays for directions all around centre in increments of 30 degrees
        float _r3 = Mathf.Sqrt(3f);
        rays.Add(new Ray2D(Vector2.zero, Vector2.right));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(_r3, 1f)));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(1f, _r3)));
        rays.Add(new Ray2D(Vector2.zero, Vector2.up));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(-1f, _r3)));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(-_r3, 1f)));
        rays.Add(new Ray2D(Vector2.zero, Vector2.left));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(-_r3, -1f)));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(-1, -_r3)));
        rays.Add(new Ray2D(Vector2.zero, Vector2.down));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(1f, -_r3)));
        rays.Add(new Ray2D(Vector2.zero, new Vector2(_r3, -1f)));


        // put spawnpoints on all of them at a distance of x
        foreach (Ray2D ray in rays)
        {
            Vector2 spawnLoc = ray.GetPoint(_distance);
            Instantiate(spawnPoint, spawnLoc, Quaternion.FromToRotation(spawnLoc, pointsParent.transform.position) , pointsParent.transform);
        }
    }
}
