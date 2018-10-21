using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int speed = 10;

    private float xMin;
    private float xMax;
    private float yMin;
    private float yMax;

    void Start()
    {
        setUpMovementBoundaries();
    }

    private void setUpMovementBoundaries()
    {
        var gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector2(0, 0)).x;
        xMax = gameCamera.ViewportToWorldPoint(new Vector2(1, 0)).x;
        yMin = gameCamera.ViewportToWorldPoint(new Vector2(0, 0)).y;
        yMax = gameCamera.ViewportToWorldPoint(new Vector2(0, 1)).y;
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
        newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);
        newPosition.y = Mathf.Clamp(newPosition.y, yMin, yMax);
        transform.position = newPosition;
    }
}
