using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

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
        var lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(lastSceneIndex);
    }

    public void quit()
    {
        Application.Quit();
    }
}
