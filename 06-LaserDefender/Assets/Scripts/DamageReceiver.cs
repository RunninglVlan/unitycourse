using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    const string PLAYER_TAG = "Player";

    [SerializeField] GameObject explosionPrefab;
    [SerializeField] float explosionDuration = 1;

    [SerializeField] int health = 100;

    private SoundFxPlayer soundFxPlayer;
    private GameSession gameSession;

    void Start()
    {
        soundFxPlayer = FindObjectOfType<SoundFxPlayer>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var damageDealer = other.GetComponent<DamageDealer>();
        if (damageDealer)
        {
            getHitBy(damageDealer);
        }
    }

    private void getHitBy(DamageDealer damageDealer)
    {
        health -= damageDealer.damageDealt();
        if (health <= 0)
        {
            playVfxAndDestroy();
            increaseScore();
        }
        else
        {
            soundFxPlayer.damage();
        }
        damageDealer.hit();
    }

    private void playVfxAndDestroy()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, explosionDuration);
        soundFxPlayer.explosion();
        Destroy(gameObject);
    }

    private void increaseScore()
    {
        if (tag == PLAYER_TAG)
        {
            return;
        }
        gameSession.increaseScore();
    }
}
