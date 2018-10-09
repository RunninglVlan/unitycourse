using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle;
    [SerializeField] Vector2 launchImpulse;

    private Vector2 distanceToPaddle;
    private bool isLaunched = false;

    void Start()
    {
        distanceToPaddle = transform.position - paddle.transform.position;
    }

    void OnCollisionEnter2D(Collision2D _)
    {
        if (isLaunched)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    void Update()
    {
        if (!isLaunched)
        {
            stickToThePaddle();
            launchOnMouseClick();
        }
    }

    private void stickToThePaddle()
    {
        Vector2 paddlePosition = paddle.transform.position;
        transform.position = paddlePosition + distanceToPaddle;
    }

    private void launchOnMouseClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isLaunched = true;
            GetComponent<Rigidbody2D>().AddForce(launchImpulse, ForceMode2D.Impulse);
            paddle.GetComponent<AudioSource>().Play();
        }
    }
}
