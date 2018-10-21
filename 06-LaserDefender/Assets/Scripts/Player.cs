using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int speed = 10;

    void Update()
    {
        move();
    }

    private void move()
    {
        var delta = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        delta.Normalize();
        delta *= speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + delta.x, transform.position.y + delta.y);
    }
}
