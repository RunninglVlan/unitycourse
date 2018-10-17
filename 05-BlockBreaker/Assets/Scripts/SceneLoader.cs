using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private GameSession gameSession;

    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
    }
    public void nextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void startScene()
    {
        SceneManager.LoadScene(0);
        gameSession?.reset();
    }

    public void quit()
    {
        Application.Quit();
    }
}
