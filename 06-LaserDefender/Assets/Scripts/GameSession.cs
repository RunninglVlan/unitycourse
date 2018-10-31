using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreTextComponent;

    private int currentScore = 0;

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

    void Start()
    {
        showScore();
    }

    private void showScore()
    {
        scoreTextComponent.text = currentScore.ToString();
    }
}
