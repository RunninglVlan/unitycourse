using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int movementSpeed = 10;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] int laserSpeed = 10;

    private Vector2 minBoundary;
    private Vector2 maxBoundary;

    void Start()
    {
        setUpMovementBoundaries();
    }

    private void setUpMovementBoundaries()
    {
        var gameCamera = Camera.main;
        Vector2 extents = GetComponent<Renderer>().bounds.extents;
        minBoundary = gameCamera.ViewportToWorldPoint(Vector2.zero);
        minBoundary += extents;
        maxBoundary = gameCamera.ViewportToWorldPoint(Vector2.one);
        maxBoundary -= extents;
    }

    void Update()
    {
        move();
        fire();
    }

    private void move()
    {
        var delta = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        delta.Normalize();
        delta *= movementSpeed * Time.deltaTime;
        var newPosition = transform.position + delta;
        newPosition.x = Mathf.Clamp(newPosition.x, minBoundary.x, maxBoundary.x);
        newPosition.y = Mathf.Clamp(newPosition.y, minBoundary.y, maxBoundary.y);
        transform.position = newPosition;
    }

    private void fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, laserSpeed);
        }
    }
}
