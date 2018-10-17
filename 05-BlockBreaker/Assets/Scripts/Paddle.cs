﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] int paddleWidth = 2;
    [SerializeField] float clipStart = 0.2f;

    private float cameraWidth;
    private GameSession gameSession;
    private Ball ball;

    void Start()
    {
        var camera = Camera.main;
        cameraWidth = camera.orthographicSize * 2 * camera.aspect;
        GetComponent<AudioSource>().time = clipStart;
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    void Update()
    {
        transform.position = new Vector2(newPositionX(), transform.position.y);
    }

    private float newPositionX()
    {
        if (gameSession.isAutoplayEnabled())
        {
            return ball.transform.position.x;
        }
        else
        {
            var mousePositionX = Input.mousePosition.x / Screen.width * cameraWidth;
            var mousePositionXInScene = Mathf.Clamp(mousePositionX, 0 + paddleWidth / 2, cameraWidth - paddleWidth / 2);
            return mousePositionXInScene;
        }
    }
}
