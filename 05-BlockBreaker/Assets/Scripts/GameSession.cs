using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{

    [Range(0.1f, 10)]
    [SerializeField] float gameSpeed = 1;
    [SerializeField] int pointsForDestroyedBlock = 25;
    [SerializeField] TextMeshProUGUI scoreTextComponent;
    [SerializeField] int lives = 3;
    [SerializeField] TextMeshProUGUI livesTextComponent;

    private int currentScore = 0;

    void Awake()
    {
        var gameStatuses = FindObjectsOfType<GameSession>().Length;
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
        showLives();
    }

    public void reset()
    {
        Destroy(gameObject);
    }

    public void loseLife()
    {
        lives--;
        if (lives > 0)
        {
            showLives();
        }
    }

    private void showLives()
    {
        livesTextComponent.text = (lives - 1).ToString();
    }

    public bool noMoreLives()
    {
        return lives <= 0;
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
