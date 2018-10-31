using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{

    private GameSession gameSession;

    protected override void Start()
    {
        base.Start();
        gameSession = FindObjectOfType<GameSession>();
    }

    protected override void onDeath()
    {
        increaseScore();
    }

    private void increaseScore()
    {
        gameSession.increaseScore();
    }
}
