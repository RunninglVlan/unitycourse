using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] int paddleWidth = 2;
    [SerializeField] float clipStart = 0.2f;
    [SerializeField] SpriteRenderer playground;

    private float playgroundWidth;
    private Ball ball;

    void Start()
    {
        playgroundWidth = playground.bounds.max.x;
        GetComponent<AudioSource>().time = clipStart;
        ball = FindObjectOfType<Ball>();
    }

    void Update()
    {
        transform.position = new Vector2(newPositionX(), transform.position.y);
    }

    private float newPositionX()
    {
        if (FindObjectOfType<GameSession>().isAutoplayEnabled())
        {
            return ball.transform.position.x;
        }
        else
        {
            var mousePositionX = Input.mousePosition.x / Screen.width * playgroundWidth;
            var paddleExtent = paddleWidth / 2;
            var mousePositionXInScene = Mathf.Clamp(mousePositionX, 0 + paddleExtent, playgroundWidth - paddleExtent);
            return mousePositionXInScene;
        }
    }
}
