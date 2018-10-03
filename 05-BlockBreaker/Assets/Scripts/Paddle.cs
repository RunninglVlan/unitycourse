﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] int paddleWidth = 2;

    private float cameraWidth;

    void Start()
    {
        var camera = Camera.main;
        cameraWidth = camera.orthographicSize * 2 * camera.aspect;
    }

    void Update()
    {
        var mousePositionX = Input.mousePosition.x / Screen.width * cameraWidth;
        var newPositionX = Mathf.Clamp(mousePositionX, 0 + paddleWidth / 2, cameraWidth - paddleWidth / 2);
        var newPosition = new Vector2(newPositionX, transform.position.y);
        transform.position = newPosition;
    }
}
