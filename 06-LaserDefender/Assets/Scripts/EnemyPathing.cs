using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{

    [SerializeField] WaveConfig waveConfig;

    private List<Transform> waypoints = new List<Transform>();
    private GameObject enemy;

    private int waypointIndex = 0;

    void Start()
    {
        waypoints = waveConfig.waypoints;
        enemy = Instantiate(waveConfig.enemyPrefab, waypoints[waypointIndex].position, Quaternion.identity);
    }

    void Update()
    {
        move();
    }

    private void move()
    {
        if (waypointIndex < waypoints.Count)
        {
            var targetPosition = waypoints[waypointIndex].position;
            var movementThisFrame = waveConfig.movementSpeed * Time.deltaTime;
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, targetPosition, movementThisFrame);
            if (enemy.transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(enemy.gameObject);
        }
    }
}
