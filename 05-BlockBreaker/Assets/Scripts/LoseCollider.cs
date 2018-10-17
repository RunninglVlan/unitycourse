using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

    private GameSession gameSession;
    private Ball ball;

    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    void OnTriggerEnter2D(Collider2D _)
    {
        gameSession.loseLife();
        if (gameSession.noMoreLives())
        {
            loadLastScene();
        }
        else
        {
            ball.resetPosition();
        }
    }

    private void loadLastScene()
    {
        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(lastSceneIndex);
    }
}
