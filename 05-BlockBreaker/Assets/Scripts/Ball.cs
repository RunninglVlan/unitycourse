using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle;
    [SerializeField] Vector2 launchImpulse;

    private Vector2 distanceToPaddle;
    private bool ballLaunched = false;

    void Start()
    {
        distanceToPaddle = transform.position - paddle.transform.position;
    }

    void Update()
    {
        if (!ballLaunched)
        {
            stickToThePaddle();
            launchOnMouseClick();
        }
    }

    private void stickToThePaddle()
    {
        var paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePosition + distanceToPaddle;
    }

    private void launchOnMouseClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ballLaunched = true;
            GetComponent<Rigidbody2D>().AddForce(launchImpulse, ForceMode2D.Impulse);
        }
    }
}
