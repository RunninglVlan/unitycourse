using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle;

    private Vector2 distanceToPaddle;

    void Start()
    {
	distanceToPaddle = transform.position - paddle.transform.position;
    }

    void Update()
    {
        var paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePosition + distanceToPaddle;
    }
}
