using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    public List<Transform> waypoints => pathPrefab.transform.Cast<Transform>().ToList();
}
