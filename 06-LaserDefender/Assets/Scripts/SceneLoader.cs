using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    [SerializeField] float gameOverDelay = 1;

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void gameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void gameOver()
    {
        StartCoroutine(delayedGameOver());
    }

    private IEnumerator delayedGameOver()
    {
        yield return new WaitForSeconds(gameOverDelay);
        var lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(lastSceneIndex);
    }

    public void quit()
    {
        Application.Quit();
    }
}
