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
        var deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var deltaY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + deltaX, transform.position.y + deltaY);
    }
}
