using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int speed = 10;

    private Vector2 minBoundary;
    private Vector2 maxBoundary;

    void Start()
    {
        setUpMovementBoundaries();
    }

    private void setUpMovementBoundaries()
    {
        var gameCamera = Camera.main;
        minBoundary = gameCamera.ViewportToWorldPoint(Vector2.zero);
        maxBoundary = gameCamera.ViewportToWorldPoint(Vector2.one);
    }

    void Update()
    {
        move();
    }

    private void move()
    {
        var delta = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        delta.Normalize();
        delta *= speed * Time.deltaTime;
        var newPosition = transform.position + delta;
        newPosition.x = Mathf.Clamp(newPosition.x, minBoundary.x, maxBoundary.x);
        newPosition.y = Mathf.Clamp(newPosition.y, minBoundary.y, maxBoundary.y);
        transform.position = newPosition;
    }
}
