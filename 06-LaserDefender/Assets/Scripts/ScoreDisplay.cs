using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{

    TextMeshProUGUI textComponent;
    GameSession gameSession;

    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void Update()
    {
        textComponent.text = gameSession.score.ToString();
    }
}
