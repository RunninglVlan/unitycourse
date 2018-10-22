using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WaveConfig : ScriptableObject
{

    [SerializeField] public GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] public float timeBetweenSpawns = .5f;
    [SerializeField] public float spawnRandomFactor = .3f;
    [SerializeField] public int numberOfEnemies = 5;
    [SerializeField] public int movementSpeed = 2;

    public List<Transform> waypoints
    {
        get
        {
            var points = new List<Transform>();
            foreach (Transform child in pathPrefab.transform)
            {
                points.Add(child);
            }
            return points;
        }
    }
}
