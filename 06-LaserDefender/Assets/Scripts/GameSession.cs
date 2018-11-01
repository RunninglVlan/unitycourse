using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : Singleton
{

    public int score { get; private set; } = 0;

    public void increaseScore(int points)
    {
        score += points;
    }

    public void reset()
    {
        Destroy(gameObject);
    }
}
