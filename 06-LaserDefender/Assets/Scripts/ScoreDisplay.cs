using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{

    TextMeshProUGUI scoreTextComponent;
    GameSession gameSession;

    void Start()
    {
        scoreTextComponent = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void Update()
    {
        scoreTextComponent.text = gameSession.score.ToString();
    }
}
