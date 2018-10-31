using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : Singleton
{
    [SerializeField] int pointsForEnemy = 25;

    public int score { get; private set; } = 0;

    public void increaseScore()
    {
        score += pointsForEnemy;
    }

    public void reset()
    {
        Destroy(gameObject);
    }
}
