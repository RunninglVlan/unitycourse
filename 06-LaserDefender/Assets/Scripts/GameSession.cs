using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int pointsForEnemy = 25;

    public int score { get; private set; } = 0;

    void Awake()
    {
        ensureSingleton();
    }

    private void ensureSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void increaseScore()
    {
        score += pointsForEnemy;
    }

    public void reset()
    {
        Destroy(gameObject);
    }
}
