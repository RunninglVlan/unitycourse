using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle;
    [SerializeField] Vector2 launchImpulse;
    [SerializeField] AudioClip[] collisionSounds;
    [SerializeField] float velocityRandomFactor = 0.2f;

    new private Rigidbody2D rigidbody2D;

    private Vector2 distanceToPaddle;
    private bool isLaunched = false;

    void Start()
    {
        distanceToPaddle = transform.position - paddle.transform.position;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D _)
    {
        var velocityTweak = new Vector2(Random.Range(0, velocityRandomFactor), Random.Range(0, velocityRandomFactor));
        if (isLaunched)
        {
            AudioClip sound = collisionSounds[Random.Range(0, collisionSounds.Length)];
            GetComponent<AudioSource>().PlayOneShot(sound);
            rigidbody2D.velocity += velocityTweak;
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
            rigidbody2D.AddForce(launchImpulse, ForceMode2D.Impulse);
            paddle.GetComponent<AudioSource>().Play();
        }
    }
}
