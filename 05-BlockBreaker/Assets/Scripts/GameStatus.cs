using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{

    [Range(0.1f, 10)]
    [SerializeField]
    float gameSpeed = 1;
    [SerializeField]
    int pointsForDestroyedBlock = 25;
    [SerializeField]
    TextMeshProUGUI scoreTextComponent;

    int currentScore = 0;

    void Awake()
    {
        var gameStatuses = FindObjectsOfType<GameStatus>().Length;
        if (gameStatuses > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        Time.timeScale = gameSpeed;
        showScore();
    }

    public void increaseScore()
    {
        currentScore += pointsForDestroyedBlock;
        showScore();
    }

    private void showScore()
    {
        scoreTextComponent.text = currentScore.ToString();
    }
}
