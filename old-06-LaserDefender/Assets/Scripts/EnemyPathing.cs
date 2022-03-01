using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{

    public WaveConfig waveConfig { private get; set; }

    private List<Transform> waypoints = new List<Transform>();

    private int waypointIndex = 0;

    void Start()
    {
        waypoints = waveConfig.waypoints;
        transform.position = waypoints[waypointIndex].position;
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
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
