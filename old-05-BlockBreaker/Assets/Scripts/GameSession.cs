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
    [SerializeField] bool autoplayEnabled = false;

    private int currentScore = 0;
    private Cheat autoplayCheat = new Cheat("autoplay");
    private Cheat fastCheat = new Cheat("fast");

    void Awake()
    {
        var gameSessions = FindObjectsOfType<GameSession>().Length;
        if (gameSessions > 1)
        {
            gameObject.SetActive(false);
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

    void Update()
    {
        autoplayCheat.ifEntered(_ => autoplayEnabled = !autoplayEnabled);
        fastCheat.ifEntered(enabled =>
        {
            gameSpeed = enabled ? 5 : 1;
            Time.timeScale = gameSpeed;
        });
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

    public bool isAutoplayEnabled()
    {
        return autoplayEnabled;
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
