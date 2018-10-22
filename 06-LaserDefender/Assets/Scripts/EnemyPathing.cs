using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{

    [SerializeField] List<Transform> waypoints = new List<Transform>();
    [SerializeField] float movementSpeed = 2;

    private int waypointIndex = 0;

    void Start()
    {
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
            var movementThisFrame = movementSpeed * Time.deltaTime;
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
