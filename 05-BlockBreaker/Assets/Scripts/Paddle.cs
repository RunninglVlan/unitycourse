using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    private float cameraWidth;

    void Start()
    {
        var camera = Camera.main;
        cameraWidth = camera.orthographicSize * 2 * camera.aspect;
    }

    void Update()
    {
        var mousePositionX = Input.mousePosition.x / Screen.width * cameraWidth;
        var newPosition = new Vector2(mousePositionX, transform.position.y);
        transform.position = newPosition;
    }
}
