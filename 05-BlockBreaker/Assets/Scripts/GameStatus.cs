using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{

    [Range(0.1f, 10)]
    [SerializeField]
    float gameSpeed = 1;
    [SerializeField]
    int pointsForDestroyedBlock = 25;

    [SerializeField]
    int currentScore = 0;

    void Start()
    {
        Time.timeScale = gameSpeed;
    }

    public void increaseScore()
    {
        currentScore += pointsForDestroyedBlock;
    }
}
