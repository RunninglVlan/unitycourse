using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D _)
    {
        var gameSession = FindObjectOfType<GameSession>();
        gameSession.loseLife();
        if (gameSession.noMoreLives())
        {
            loadLastScene();
        }
        else
        {
            FindObjectOfType<Ball>().resetPosition();
        }
    }

    private void loadLastScene()
    {
        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(lastSceneIndex);
    }
}
